using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;
using Duisv.Validaciones;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmEditarCiudadano : Form
    {
        private readonly CiudadanoServicio _ciudadanoServicio;
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;
        private readonly string _ciudadanoId;

        private bool _cambiarFoto;
        private bool _cambiarFirma;
        private bool _cambiarPartidaNacimiento;

        public FrmEditarCiudadano(string ciudadanoId)
        {
            InitializeComponent();

            _ciudadanoServicio = new CiudadanoServicio();
            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
            _ciudadanoId = ciudadanoId;
            _cambiarFirma = false;
            _cambiarFoto = false;
            _cambiarPartidaNacimiento = false;
        }

        private void MostrarDatos()
        {
            var departamentos = _departamentoServicio.ObtenerListaDepartamentos();

            MostrarListaDespartamentos(departamentos, ref departamentoNacimientoComboBox);
            MostrarListaDespartamentos(departamentos, ref departamentoResidenciaComboBox);

            var ciudadano = _ciudadanoServicio.ObtenerCiudadanoPorId(_ciudadanoId);

            if (ciudadano != null)
            {
                ciudadanoBindingSource.DataSource = ciudadano;
            }

            var nombres = ((Ciudadano)ciudadanoBindingSource.Current).Nombres;
            var apellidos = ((Ciudadano)ciudadanoBindingSource.Current).Apellidos;
            var numeroDui = ((Ciudadano)ciudadanoBindingSource.Current).NumeroDocumento;

            CargarFoto(numeroDui);
            CargarFirma(numeroDui);
            CargarPartidaNacimiento(numeroDui);


            LblTituloVentana.Text = $"Editar datos del ciudadano {nombres.ToUpper()} {apellidos.ToUpper()}";
        }

        private void MostrarListaMunicipios(ref ComboBox comboBox, string departamentoId)
        {
            var municipios = _municipioServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId);

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "MunicipioId";
            comboBox.DataSource = municipios;
        }

        private void MostrarListaDespartamentos(List<Departamento> departamentos, ref ComboBox comboBox)
        {

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "DepartamentoId";
            comboBox.DataSource = departamentos;
        }

        private void FrmEditarCiudadano_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void DepartamentoNacimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = ((ComboBox)sender).SelectedValue.ToString();

            if (departamentoId != string.Empty)
            {
                MostrarListaMunicipios(ref municipioNacimientoComboBox, departamentoId);
            }
        }

        private void DepartamentoResidenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = ((ComboBox)sender).SelectedValue.ToString();

            if (departamentoId != string.Empty)
            {
                MostrarListaMunicipios(ref municipioResidenciaComboBox, departamentoId);
            }
        }

        private void CargarPartidaNacimiento(string numeroDui)
        {
            var archivo = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DUISV\Ciudadanos\Documentos\{numeroDui}.pdf";

            if (File.Exists(archivo))
            {
                TBxRutaDocumento.Text = archivo;
            }
        }

        private void CargarFoto(string numeroDui)
        {
            try
            {
                var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Ciudadanos\Fotos\{numeroDui}.png";

                if (File.Exists(rutaFoto))
                {
                    PBxFoto.Image.Dispose();
                    PBxFoto.Image = Image.FromFile(rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar ciudadano: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFirma(string numeroDui)
        {
            try
            {
                var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Ciudadanos\Firmas\{numeroDui}.png";

                if (File.Exists(rutaFoto))
                {
                    PBxFirma.Image.Dispose();
                    PBxFirma.Image = Image.FromFile(rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar ciudadano: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _cambiarFoto = true;
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

            if (frmTomarFoto.ShowDialog() == DialogResult.OK)
            {
                _cambiarFoto = true;
            }
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
                    _cambiarFirma = true;
                }
            }
        }

        private void BtnPartidaNacimiento_Click(object sender, EventArgs e)
        {
            var frmElegirPartidaNacimiento = new FrmElegirPartidaNacimiento();

            if (frmElegirPartidaNacimiento.ShowDialog() == DialogResult.OK)
            {
                TBxRutaDocumento.Text = frmElegirPartidaNacimiento.RutaDocumento;
                _cambiarPartidaNacimiento = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ciudadanoBindingSource.EndEdit();

            var ciudadano = ciudadanoBindingSource.Current as Ciudadano;

            if (ciudadano != null)
            {
                if (ValidarDatosCiudadano(ciudadano))
                {
                    if (_ciudadanoServicio.EditarCiudadano(ciudadano) > 0)
                    {
                        if (_cambiarFirma)
                        {
                            GuardarFirma(ciudadano.NumeroDocumento);
                        }
                        if (_cambiarFoto)
                        {
                            GuardarFoto(ciudadano.NumeroDocumento);
                        }
                        if (_cambiarPartidaNacimiento)
                        {
                            GuardarPartidaNacimiento(ciudadano.NumeroDocumento);
                        }

                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void GuardarPartidaNacimiento(string nombre)
        {
            try
            {
                var directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DUISV\Ciudadanos\Documentos\";
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
                MessageBox.Show(ex.Message, "Agregar ciudadano: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarFoto(string nombre)
        {
            var rutaCarpeta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Ciudadanos\Fotos\";
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
            var directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Ciudadanos\Firmas\";
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

        private bool ValidarDatosCiudadano(Ciudadano ciudadano)
        {
            var valido = true;
            var validador = new AgregarCiudadanoValidador();
            var resultado = validador.Validate(ciudadano);
            var errores = resultado.Errors;

            if (!resultado.IsValid)
            {
                foreach (var error in errores)
                {
                    MessageBox.Show(error.ErrorMessage, "Agregar ciudadano: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                valido = false;
            }

            return valido;
        }
    }
}