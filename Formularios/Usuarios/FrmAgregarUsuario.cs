using System;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmAgregarUsuario : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public FrmAgregarUsuario()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                Nombre = TBxNombre.Text,
                Apellido = TBxApellido.Text,
                Direccion = TBxDireccion.Text,
                CorreoElectronico = TBxCorreo.Text,
                FechaNacimiento = DtpFechaNacimiento.Value,
                Telefono = MtbTelefono.Text,
                Rol = RBtAdministrador.Checked ? "Administrador" : "Empleado"
            };

            if (await _usuarioServicio.AgregarUsuario(usuario) > 0)
            {
                DialogResult = DialogResult.OK;
            }            
        }

        private void PBxMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
