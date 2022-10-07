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
    public partial class FrmAgregarCiudadano : Form
    {
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;
        private readonly CiudadanoServicio _ciudadanoServicio;
        private bool _guardarFoto;

        public FrmAgregarCiudadano()
        {
            InitializeComponent();

            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
            _ciudadanoServicio = new CiudadanoServicio();
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
            ciudadanoBindingSource.DataSource = new Ciudadano();

            var departamentos = _departamentoServicio.ObtenerListaDepartamentos();
            departamentos.Insert(0, new Departamento { DepartamentoId = 0, Nombre = "-- Seleccionar --" });

            MostrarListaDespartamentos(departamentos, ref departamentoResidenciaComboBox);
            MostrarListaDespartamentos(departamentos, ref departamentoNacimientoComboBox);

            ciudadanoPorComboBox.SelectedIndex = 0;
            generoComboBox.SelectedIndex = 0;
            estadoFamiliarComboBox.SelectedIndex = 0;
            tipoSangreComboBox.SelectedIndex = 0;
            profesionComboBox.SelectedIndex = 0;
        }

        private void DepartamentoNacimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioNacimientoComboBox, departamentoId);
            }
        }

        private void MostrarListaMunicipios(ref ComboBox comboBox, int departamentoId)
        {
            var municipios = _municipioServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId);

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "MunicipioId";
            comboBox.DataSource = municipios;
        }

        private void DepartamentoResidenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioResidenciaComboBox, departamentoId);
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ciudadanoBindingSource.EndEdit();

            var ciudadano = ciudadanoBindingSource.Current as Ciudadano;

            if (ciudadano != null)
            {
                if (ValidarDatosCiudadano(ciudadano))
                {
                    if (_ciudadanoServicio.AgregarCiudadano(ciudadano) > 0)
                    {
                        if (_guardarFoto)
                        {
                            GuardarFoto(string.Concat(ciudadano.Nombres, ciudadano.Apellidos));
                        }

                        DialogResult = DialogResult.OK;
                    }
                }
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
            string rutaCarpeta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Ciudadanos\Fotos\";
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

        private void BtnTomarFoto_Click(object sender, EventArgs e)
        {
            TomarFoto(ref PBxFoto);
        }

        private void TomarFoto(ref PictureBox pictureBox)
        {
            var frmTomarFoto = new FrmTomarFoto(ref pictureBox);

            if (frmTomarFoto.ShowDialog() == DialogResult.OK)
            {
                _guardarFoto = true;
            }
        }
    }
}