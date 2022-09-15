using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmListaUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public FrmListaUsuarios()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmAgregarUsuario = new FrmAgregarUsuario();

            if (frmAgregarUsuario.ShowDialog() == DialogResult.OK)
            {
                ActualizarListaUsuarios(_usuarioServicio.ObtenerListaUsuarios());
            }
        }

        private void ActualizarListaUsuarios(List<Usuario> usuarios)
        {
            DgvUsuarios.Rows.Clear();

            if (usuarios.Count > 0 && usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
                    DgvUsuarios.Rows.Add(usuario.UsuarioId, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Rol);
                }

                DgvUsuarios.ClearSelection();
            }
        }

        private void PBxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarListaUsuarios(_usuarioServicio.ObtenerListaUsuarios());
        }
    }
}
