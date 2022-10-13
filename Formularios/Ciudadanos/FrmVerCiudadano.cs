using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmVerCiudadano : Form
    {

        private readonly CiudadanoServicio _ciudadanoServicio;
        private readonly DocumentoServicio _documentoServicio;

        private readonly int _ciudadanoId;

        public FrmVerCiudadano(int ciudadanoId)
        {
            InitializeComponent();

            _ciudadanoServicio = new CiudadanoServicio();
            _documentoServicio = new DocumentoServicio();

            _ciudadanoId = ciudadanoId;
        }

        private void FrmVerCiudadano_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            var ciudadano = _ciudadanoServicio.ObtenerCiudadanoPorId(_ciudadanoId);

            if (ciudadano != null)
            {
                var documento = _documentoServicio.ObtenerDocumentoPorId((int)ciudadano.DocumentoId);

                if (documento != null)
                {
                    ciudadanoBindingSource.DataSource = ciudadano;
                    DocumentoBindingSource.DataSource = documento;
                }
            }

            var nombres = ((Ciudadano)ciudadanoBindingSource.Current).Nombres;
            var apellidos = ((Ciudadano)ciudadanoBindingSource.Current).Apellidos;
            var numeroDui = ((Ciudadano)ciudadanoBindingSource.Current).NumeroDocumento;

            CargarFoto(numeroDui);
            CargarFirma(numeroDui);

            LblTituloVentana.Text = $"Ver datos del ciudadano {nombres.ToUpper()} {apellidos.ToUpper()}";
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

        private void BtnVerPartidaNacimiento_Click(object sender, EventArgs e)
        {
            var numeroDui = ((Ciudadano)ciudadanoBindingSource.Current).NumeroDocumento;
            var frmElegirPartidaNacimiento = new FrmElegirPartidaNacimiento();
            var archivo = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DUISV\Ciudadanos\Documentos\{numeroDui}.pdf";

            frmElegirPartidaNacimiento.BtnImportarDocumento.Enabled = false;
            frmElegirPartidaNacimiento.BtnGuardarDocumento.Text = "Cerrar";
            frmElegirPartidaNacimiento.LblUsuario.Text = "Ver partida de nacimiento del ciudadano";

            if (File.Exists(archivo))
            {
                frmElegirPartidaNacimiento.axAcroPDF.src = archivo;
                frmElegirPartidaNacimiento.ShowDialog();
            }
            else
            {
                MessageBox.Show("El archivo correspondiente a la partida de nacimiento no existe.", "Ver ciudadano: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerDui_Click(object sender, EventArgs e)
        {
            var ciudadano = (Ciudadano)ciudadanoBindingSource.Current;
            var documento = (Documento)DocumentoBindingSource.Current;

            var frmMostrarDui = new FrmMostrarDui(ciudadano, documento);
            frmMostrarDui.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
