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
    public partial class FrmEditarUsuario : Form
    {
        private readonly int _usuarioId;
        private readonly UsuarioServicio _usuarioServicio;
        private readonly RolServicio _rolServicio;
        private bool _eliminarFoto;
        private bool _cambiarFoto;

        public FrmEditarUsuario(int usuarioId)
        {
            InitializeComponent();

            _usuarioId = usuarioId;
            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
            _eliminarFoto = false;
            _cambiarFoto = false;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            var usuario = _usuarioServicio.ObtenerUsuarioPorId(_usuarioId);

            if (usuario != null)
            {
                ActualizarListaRoles(_rolServicio.ObtenerListaRoles());
                MostrarDatosUsuario(usuario);
            }
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

        private void MostrarDatosUsuario(Usuario usuario)
        {
            LblUsuario.Text = $"Editar datos del usuario {usuario.NombreUsuario.ToUpper()}";
            TBxId.Text = usuario.UsuarioId.ToString();
            TBxNombre.Text = usuario.Nombre;
            TBxApellido.Text = usuario.Apellido;
            TBxCorreo.Text = usuario.CorreoElectronico;
            DtpFechaNacimiento.Value = usuario.FechaNacimiento.Value;
            TBxDireccion.Text = usuario.Direccion;
            MtbTelefono.Text = usuario.Telefono;
            CbBRoles.SelectedValue = usuario.RolId ?? 0;
            TBxUsuario.Text = usuario.NombreUsuario;

            CargarFotoUsuario(usuario.NombreUsuario);
        }

        private void CargarFotoUsuario(string nombreUsuario)
        {
            var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Usuarios\Fotos\{nombreUsuario}.png";

            if (File.Exists(rutaFoto))
            {
                PBxFoto.Image.Dispose();
                PBxFoto.Image = Image.FromFile(rutaFoto);
            }
        }

        private void CBxVerClaves_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
            TBxRepetirClave.UseSystemPasswordChar = !CBxVerClaves.Checked;
        }

        private bool ValidarDatosUsuario(Usuario usuario)
        {
            var cambiarClave = !CBxNoCambiarClave.Checked;
            var validador = new EditarUsuarioValidador(cambiarClave);
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario()
                {
                    UsuarioId = Convert.ToInt32(TBxId.Text),
                    Nombre = TBxNombre.Text,
                    Apellido = TBxApellido.Text,
                    Direccion = TBxDireccion.Text,
                    CorreoElectronico = TBxCorreo.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value,
                    Telefono = MtbTelefono.Text,
                    NombreUsuario = TBxUsuario.Text,
                    Clave = TBxClave.Text,
                    RepetirClave = TBxClave.Text,
                    RolId = Convert.ToInt32(CbBRoles.SelectedValue)
                };

                if (ValidarDatosUsuario(usuario))
                {
                    if (_usuarioServicio.EditarUsuario(usuario) > 0)
                    {
                        if (CBxNoCambiarClave.CheckState == CheckState.Unchecked)
                        {
                            string claveCodificada = Codificador.ObtenerClaveCodificada(string.Concat(usuario.NombreUsuario, usuario.Clave));

                            if (_usuarioServicio.CambiarClaveUsuario(claveCodificada, usuario.UsuarioId) > 0)
                            {
                                if (_cambiarFoto)
                                {
                                    GuardarFotoUsuario(usuario.NombreUsuario);
                                }
                                else if (_eliminarFoto)
                                {
                                    EliminarFotoUsuario(usuario.NombreUsuario);
                                }
                            }
                        }

                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al editar el usuario: \n{ex.Message}", "Agregar usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarFotoUsuario(string nombreUsuario)
        {
            var rutaFoto = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\DUISV\Usuarios\Fotos\{nombreUsuario}.png";

            if (File.Exists(rutaFoto))
            {
                File.Delete(rutaFoto);
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

        private void BtnEliminarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                PBxFoto.Image.Dispose();
                PBxFoto.Image = Properties.Resources.usuario;
                _eliminarFoto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al eliminar la foto del usuario: \n{ex.Message}", "Eliminar foto: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al agregar la foto del usuario: \n{ex.Message}", "Agregar foto: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBxCambiarClave_CheckedChanged(object sender, EventArgs e)
        {
            PnlClave.Enabled = !CBxNoCambiarClave.Checked;
        }
    }
}
