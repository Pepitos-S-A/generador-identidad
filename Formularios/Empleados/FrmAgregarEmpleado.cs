using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;
using Duisv.Validaciones;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmAgregarEmpleado : Form
    {
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;
        private readonly EmpleadoServicio _ciudadanoServicio;
        private readonly DocumentoServicio _documentoServicio;

        private bool _guardarFoto;

        public FrmAgregarEmpleado()
        {
            InitializeComponent();

            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
            _ciudadanoServicio = new EmpleadoServicio();
            _documentoServicio = new DocumentoServicio();
            _guardarFoto = false;


        }

        private void MostrarListaDespartamentos(List<Departamento> departamentos, ref ComboBox comboBox)
        {
            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "DepartamentoId";
            comboBox.DataSource = departamentos;
        }

        private void FrmAgregarCiudadano_Load(object sender, EventArgs e)
        {
            ciudadanoBindingSource.DataSource = new Empleado();

            var departamentos = _departamentoServicio.ObtenerListaDepartamentos();
            departamentos.Insert(0, new Departamento { DepartamentoId = string.Empty, Nombre = "-- Seleccionar --" });

            MostrarListaDespartamentos(departamentos, ref departamentoResidenciaComboBox);
            MostrarListaDespartamentos(departamentos, ref departamentoNacimientoComboBox);

            generoComboBox.SelectedIndex = 0;
            generoComboBox.BindingContext = new BindingContext();
            estadoFamiliarComboBox.SelectedIndex = 0;
            profesionComboBox.SelectedIndex = 0;
        }

        private void DepartamentoNacimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = ((ComboBox)sender).SelectedValue.ToString();

            if (departamentoId != string.Empty)
            {
                MostrarListaMunicipios(ref municipioNacimientoComboBox, departamentoId);
            }
        }

        private void MostrarListaMunicipios(ref ComboBox comboBox, string departamentoId)
        {
            var municipios = _municipioServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId);

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "MunicipioId";
            comboBox.DataSource = municipios;
        }

        private void DepartamentoResidenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = ((ComboBox)sender).SelectedValue.ToString();

            if (departamentoId != string.Empty)
            {
                MostrarListaMunicipios(ref municipioResidenciaComboBox, departamentoId);
            }
        }

        private bool ValidarDatos(Empleado ciudadano)
        {
            var valido = true;
            var validador = new AgregarEmpleadoValidador();
            var resultado = validador.Validate(ciudadano);
            var errores = resultado.Errors;

            if (!resultado.IsValid)
            {
                foreach (var error in errores)
                {
                    MessageBox.Show(error.ErrorMessage, "Agregar empleado: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                valido = false;
            }

            return valido;
        }

        private bool ValidarAdjuntos()
        {
            var validos = true;
            var mensaje = string.Empty;

            if (_guardarFoto == false)
            {
                validos = false;
                mensaje = "La foto del empleado es requerida.";
            }
            else if (string.IsNullOrEmpty(PBxFirma.ImageLocation))
            {
                validos = false;
                mensaje = "La firma del empleado es requerida.";
            }
            else if (string.IsNullOrEmpty(TBxRutaDocumento.Text))
            {
                validos = false;
                mensaje = "La partida de nacimiento del empleado es requerida.";
            }

            if (validos == false)
            {
                MessageBox.Show(mensaje, "Agregar empleado: error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validos;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ciudadanoBindingSource.EndEdit();

            var empleado = ciudadanoBindingSource.Current as Empleado;

            if (empleado != null)
            {
                if (ValidarDatos(empleado) && ValidarAdjuntos())
                {
                    var documento = new Documento
                    {
                        FechaExpedicion = DateTime.Today,
                        MunicipioExpedicion = "Santa Ana",
                        DepartamentoExpedicion = "Santa Ana",
                        FechaExpiracion = DateTime.Today.AddYears(8),
                        Numero = GenerarNumero(),
                        TipoTramite = "RP-1",
                        CodigoZona = "102020000T",
                        NumeroFolio = "M04587545"
                    };

                    if ((documento.DocumentoId = _documentoServicio.AgregarDocumento(documento)) != string.Empty)
                    {
                        empleado.DocumentoId = documento.DocumentoId;
                        empleado.NumeroDocumento = documento.Numero;

                        if (_ciudadanoServicio.AgregarEmpleado(empleado) > 0)
                        {
                            GuardarFoto(empleado.NumeroDocumento);
                            GuardarFirma(empleado.NumeroDocumento);
                            GuardarPartidaNacimiento(empleado.NumeroDocumento);

                            var frmMostrarDui = new FrmMostrarIdentificacion(empleado, documento);

                            if (frmMostrarDui.ShowDialog() == DialogResult.OK)
                            {
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }
        }

        private string GenerarNumero()
        {
            var numero = new StringBuilder(9);
            var aleatorio = new Random();

            for (int i = 0; i < 9; i++)
            {
                numero.Append(aleatorio.Next(0, 9));
            }

            return numero.ToString();
        }

        private void GuardarPartidaNacimiento(string nombre)
        {
            try
            {
                var directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PepitosSA\Empleados\Documentos\";
                var archivo = string.Concat(nombre, ".pdf");
                var ruta = string.Concat(directorio, archivo);

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                if (File.Exists(TBxRutaDocumento.Text))
                {
                    File.Copy(TBxRutaDocumento.Text, ruta, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar empleado: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
        {
            OfdImportarFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (OfdImportarFoto.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(OfdImportarFoto.FileName))
                {
                    PBxFoto.Image.Dispose();
                    PBxFoto.Image = Image.FromFile(OfdImportarFoto.FileName);
                    PBxFoto.ImageLocation = OfdImportarFoto.FileName;
                    _guardarFoto = true;
                }
            }
        }

        private void GuardarFoto(string nombre)
        {
            var rutaCarpeta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Fotos\";
            string nombreFoto = $"{nombre}.png";
            string rutaNuevaFoto = string.Concat(rutaCarpeta, nombreFoto);

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            if (PBxFoto.Image != null)
            {
                using (var bitmap = new Bitmap(PBxFoto.Image, 170, 170))
                {
                    using (var stream = new FileStream(rutaNuevaFoto, FileMode.Create, FileAccess.Write))
                    {
                        bitmap.Save(stream, ImageFormat.Png);
                    }
                }
            }
        }

        private void GuardarFirma(string nombre)
        {
            var directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Firmas\";
            string archivo = $"{nombre}.png";
            string ruta = string.Concat(directorio, archivo);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            if (PBxFirma.Image != null)
            {
                using (var bitmap = new Bitmap(PBxFirma.Image, 172, 94))
                {
                    using (var stream = new FileStream(ruta, FileMode.Create, FileAccess.Write))
                    {
                        bitmap.Save(stream, ImageFormat.Png);
                    }
                }
            }
        }

        private void BtnTomarFoto_Click(object sender, EventArgs e)
        {
            TomarFoto(ref PBxFoto);
        }

        private void TomarFoto(ref PictureBox pictureBox)
        {
            var frmTomarFoto = new FrmTomarFoto(ref pictureBox);
            frmTomarFoto.ShowDialog();
            _guardarFoto = true;
        }

        private void BtnPartidaNacimiento_Click(object sender, EventArgs e)
        {
            var frmElegirPartidaNacimiento = new FrmElegirPartidaNacimiento();

            if (frmElegirPartidaNacimiento.ShowDialog() == DialogResult.OK)
            {
                TBxRutaDocumento.Text = frmElegirPartidaNacimiento.RutaDocumento;
            }
        }

        private void BtnQuitarDocumento_Click(object sender, EventArgs e)
        {
            TBxRutaDocumento.Text = string.Empty;
        }

        private void BtnFirma_Click(object sender, EventArgs e)
        {
            OfdImportarFirma.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (OfdImportarFirma.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(OfdImportarFirma.FileName))
                {
                    PBxFirma.Image.Dispose();
                    PBxFirma.Image = Image.FromFile(OfdImportarFirma.FileName);
                    PBxFirma.ImageLocation = OfdImportarFirma.FileName;
                }
            }
        }
    }
}