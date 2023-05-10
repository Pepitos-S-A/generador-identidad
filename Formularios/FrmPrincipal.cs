using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Duisv.Formularios.Ciudadanos;
using Duisv.Formularios.Usuarios;
using Duisv.Modelos;

namespace Duisv.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private Usuario _usuario;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TBxNombre.Text = $"{_usuario.Nombre} {_usuario.Apellido}".ToUpper();

            CargarFotoUsuario(_usuario.NombreUsuario);
        }

        private void CargarFotoUsuario(string nombreUsuario)
        {
            var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Usuarios\Fotos\{nombreUsuario}.png";

            if (File.Exists(rutaFoto))
            {
                PBxFoto.Image.Dispose();
                PBxFoto.Image = Image.FromFile(rutaFoto);
            }
        }

        private void BtnEditarPerfil_Click(object sender, EventArgs e)
        {
            var frmEditarUsuario = new FrmEditarUsuario(_usuario.UsuarioId);

            if (frmEditarUsuario.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Los cambios se verán reflejados al iniciar sesión nuevamente.", "Editar usuario: Información ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmListaUsuarios(_usuario);
            frmUsuarios.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer cerrar la sesión?", "Pepitos S. A.: Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Retry;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnCiudadanos_Click(object sender, EventArgs e)
        {
            var frmListaCiudadanos = new FrmListaCiudadanos();
            frmListaCiudadanos.ShowDialog();
        }
    }
}
