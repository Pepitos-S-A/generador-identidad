using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmVerUsuario : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly int _usuarioId;

        public FrmVerUsuario(int usuarioId)
        {
            InitializeComponent();

            _usuarioId = usuarioId;
            _usuarioServicio = new UsuarioServicio();
        }

        private void FrmVerUsuario_Load(object sender, EventArgs e)
        {
            var usuario = _usuarioServicio.ObtenerUsuarioPorId(_usuarioId);

            if (usuario != null)
            {
                MostrarDatosUsuario(usuario);
            }
        }

        private void MostrarDatosUsuario(Usuario usuario)
        {
            LblUsuario.Text = $"Datos del usuario {usuario.NombreUsuario.ToUpper()}";
            TBxNombre.Text = usuario.Nombre;
            TBxApellido.Text = usuario.Apellido;
            TBxCorreo.Text = usuario.CorreoElectronico;
            TBxFechaNacimiento.Text = usuario.FechaNacimiento.Value.ToShortDateString();
            TBxDireccion.Text = usuario.Direccion;
            MtbTelefono.Text = usuario.Telefono;
            TBxRol.Text = usuario.Rol;
            TBxUsuario.Text = usuario.NombreUsuario;

            CargarFotoUsuario(usuario.NombreUsuario);
        }

        private void CargarFotoUsuario(string nombreUsuario)
        {
            var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Usuarios\Fotos\{nombreUsuario}.jpg";

            if (File.Exists(rutaFoto))
            {
                PBxFoto.Image = Image.FromFile(rutaFoto);
            }
        }
    }
}
