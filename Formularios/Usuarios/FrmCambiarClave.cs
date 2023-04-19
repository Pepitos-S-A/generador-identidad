using System;
using System.Windows.Forms;
using Duisv.Herramientas;
using Duisv.Modelos;
using Duisv.Servicios;
using Duisv.Validaciones;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmCambiarClave : Form
    {
        private readonly string _usuarioId;
        private readonly UsuarioServicio _usuarioServicio;
        private Usuario _usuario;

        public FrmCambiarClave(string usuarioId)
        {
            InitializeComponent();

            _usuarioId = usuarioId;
            _usuarioServicio = new UsuarioServicio();
        }

        private void FrmCambiarClave_Load(object sender, EventArgs e)
        {
            var usuario = _usuarioServicio.ObtenerUsuarioPorId(_usuarioId);

            if (usuario != null)
            {
                _usuario = usuario;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _usuario.Clave = TBxClave.Text;
            _usuario.RepetirClave = TBxRepetirClave.Text;

            if (ValidarClaves(_usuario))
            {
                string nuevaClave = Codificador.ObtenerClaveCodificada(string.Concat(_usuario.NombreUsuario, _usuario.Clave));

                if (_usuarioServicio.CambiarClaveUsuario(nuevaClave, _usuario.UsuarioId) > 0)
                {
                    DialogResult = MessageBox.Show("Contraseña de usuario modificada correctamente.", "Cambiar contraseña: Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarClaves(Usuario usuario)
        {
            var validador = new ClaveValidador();
            var resultado = validador.Validate(usuario);
            var errores = resultado.Errors;

            if (!resultado.IsValid)
            {
                foreach (var error in errores)
                {
                    MessageBox.Show(error.ErrorMessage, "Editar usuario: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }

                return false;
            }

            return true;
        }

        private void CBxVerClaves_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
            TBxRepetirClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
        }
    }
}
