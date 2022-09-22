using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Duisv.Herramientas;
using Duisv.Modelos;
using Duisv.Servicios;
using Duisv.Validaciones;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmAgregarUsuario : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly RolServicio _rolServicio;

        private bool _guardarFoto;

        public FrmAgregarUsuario()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
            _guardarFoto = false;
        }

        private bool ValidarDatosUsuario(Usuario usuario)
        {
            var validador = new AgregarUsuarioValidador();
            var resultado = validador.Validate(usuario);
            var errores = resultado.Errors;

            if (!resultado.IsValid)
            {
                foreach (var error in errores)
                {
                    MessageBox.Show(error.ErrorMessage, "Agregar usuario: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }

                return false;
            }

            return true;
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
                    RolId = Convert.ToInt32(CbBRoles.SelectedValue),
                    RepetirClave = TBxRepetirClave.Text
                };

                if (ValidarDatosUsuario(usuario))
                {
                    usuario.Clave = Codificador.ObtenerClaveCodificada(string.Concat(usuario.NombreUsuario, usuario.Clave));
                    usuario.RepetirClave = string.Empty;

                    if (_usuarioServicio.AgregarUsuario(usuario) > 0)
                    {
                        if (_guardarFoto)
                        {
                            GuardarFotoUsuario(usuario.NombreUsuario);
                        }

                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al guadar el usuario: \n{ex.Message}", "Agregar usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarFotoUsuario(string nombreUsuario)
        {
            string rutaCarpeta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Usuarios\Fotos\";
            string nombreFoto = $"{nombreUsuario}.png";
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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            ActualizarListaRoles(_rolServicio.ObtenerListaRoles());
        }

        private void ActualizarListaRoles(List<Rol> roles)
        {
            roles.Insert(0, new Rol { Nombre = "-- Seleccionar --", RolId = 0 });

            CbBRoles.DataSource = roles;
            CbBRoles.DisplayMember = "Nombre";
            CbBRoles.ValueMember = "RolId";
            CbBRoles.SelectedIndex = 0;
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

        private void BtnTomarFoto_Click(object sender, EventArgs e)
        {
            TomarFotoUsuario(ref PBxFoto);
        }

        private void TomarFotoUsuario(ref PictureBox pictureBox)
        {
            var frmTomarFoto = new FrmTomarFoto(ref pictureBox);

            if (frmTomarFoto.ShowDialog() == DialogResult.OK)
            {
                _guardarFoto = true;
            }
        }

        private void CBxVerClaves_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
            TBxRepetirClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
        }
    }
}
