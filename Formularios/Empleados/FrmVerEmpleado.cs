using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmVerEmpleado : Form
    {

        private readonly EmpleadoServicio _ciudadanoServicio;
        private readonly DocumentoServicio _documentoServicio;

        private readonly string _ciudadanoId;

        public FrmVerEmpleado(string ciudadanoId)
        {
            InitializeComponent();

            _ciudadanoServicio = new EmpleadoServicio();
            _documentoServicio = new DocumentoServicio();

            _ciudadanoId = ciudadanoId;
        }

        private void FrmVerCiudadano_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            var ciudadano = _ciudadanoServicio.ObtenerEmpleadoPorId(_ciudadanoId);

            if (ciudadano != null)
            {
                var documento = _documentoServicio.ObtenerDocumentoPorId(ciudadano.DocumentoId);

                if (documento != null)
                {
                    ciudadanoBindingSource.DataSource = ciudadano;
                    DocumentoBindingSource.DataSource = documento;
                }
            }

            var nombres = ((Empleado)ciudadanoBindingSource.Current).Nombres;
            var apellidos = ((Empleado)ciudadanoBindingSource.Current).Apellidos;
            var numeroDui = ((Empleado)ciudadanoBindingSource.Current).NumeroDocumento;

            CargarFoto(numeroDui);
            CargarFirma(numeroDui);

            LblTituloVentana.Text = $"Ver datos del empleado {nombres.ToUpper()} {apellidos.ToUpper()}";
        }

        private void CargarFirma(string numeroDui)
        {
            try
            {
                var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Firmas\{numeroDui}.png";

                if (File.Exists(rutaFoto))
                {
                    PBxFirma.Image.Dispose();
                    PBxFirma.Image = Image.FromFile(rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar empleado: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFoto(string numeroDui)
        {
            try
            {
                var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Fotos\{numeroDui}.png";

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
            var numeroDui = ((Empleado)ciudadanoBindingSource.Current).NumeroDocumento;
            var frmElegirPartidaNacimiento = new FrmElegirPartidaNacimiento();
            var archivo = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PepitosSA\Empleados\Documentos\{numeroDui}.pdf";

            frmElegirPartidaNacimiento.BtnImportarDocumento.Enabled = false;
            frmElegirPartidaNacimiento.BtnGuardarDocumento.Text = "Cerrar";
            frmElegirPartidaNacimiento.LblUsuario.Text = "Ver partida de nacimiento del empleado";

            if (File.Exists(archivo))
            {
                frmElegirPartidaNacimiento.axAcroPDF.src = archivo;
                frmElegirPartidaNacimiento.ShowDialog();
            }
            else
            {
                MessageBox.Show("El archivo correspondiente a la partida de nacimiento no existe.", "Ver empleado: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerDui_Click(object sender, EventArgs e)
        {
            var ciudadano = (Empleado)ciudadanoBindingSource.Current;
            var documento = (Documento)DocumentoBindingSource.Current;

            var frmMostrarDui = new FrmMostrarIdentificacion(ciudadano, documento);
            frmMostrarDui.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
