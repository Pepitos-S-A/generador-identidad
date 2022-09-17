using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmAgregarUsuario : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly RolServicio _rolServicio;

        public FrmAgregarUsuario()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario()
                {
                    Nombre = TBxNombre.Text,
                    Apellido = TBxApellido.Text,
                    Direccion = TBxDireccion.Text,
                    CorreoElectronico = TBxCorreo.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value,
                    Telefono = MtbTelefono.Text,
                    NombreUsuario = TBxUsuario.Text,
                    Clave = TBxClave.Text,
                    RolId = Convert.ToInt32(CbBRoles.SelectedValue)
                };

                if (_usuarioServicio.AgregarUsuario(usuario) > 0)
                {
                    GuardarFotoUsuario(usuario.NombreUsuario);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al guadar el usuario: \n{ex.Message}", "Agregar usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarFotoUsuario(string nombreUsuario)
        {
            string rutaCarpeta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Usuarios\Fotos";
            string rutaFotoSeleccionada = PBxFoto.ImageLocation;
            string rutaNuevaFoto = string.Concat(rutaCarpeta, @"\", nombreUsuario, ".png");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            using (var bitmap = new Bitmap(Image.FromFile(rutaFotoSeleccionada), 170, 170))
            {
                using (var stream = new FileStream(rutaNuevaFoto, FileMode.Create, FileAccess.Write))
                {
                    bitmap.Save(stream, ImageFormat.Png);
                }
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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            ActualizarListaRoles(_rolServicio.ObtenerListaRoles());
        }

        private void ActualizarListaRoles(List<Rol> roles)
        {
            if (roles != null)
            {
                roles.Insert(0, new Rol { Nombre = "-- Seleccionar --", RolId = 0 });

                CbBRoles.DataSource = roles;
                CbBRoles.DisplayMember = "Nombre";
                CbBRoles.ValueMember = "RolId";
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
                }
            }
        }

        private void BtnTomarFoto_Click(object sender, EventArgs e)
        {

        }

        private void CBxVerClaves_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
            TBxRepetirClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
        }
    }
}
