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
                    DgvUsuarios.Rows.Add(usuario.UsuarioId, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.NombreUsuario, usuario.Rol);
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

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewUsuarios = (DataGridView)sender;

            if (dataGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var usuarioId = (int)dataGridViewUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value;
                var nombreUsuario = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();

                switch (e.ColumnIndex)
                {
                    case 6:
                        AbrirFormularioVerUsuario(usuarioId);
                        break;
                    case 7:
                        AbrirFormularioEditarUsuario();
                        break;
                    case 8:
                        ConfirmarEliminarUsuario(usuarioId, nombreUsuario);
                        break;
                    default:
                        break;
                }
            }
        }

        private void AbrirFormularioVerUsuario(int usuarioId)
        {
            var frmVerUsuario = new FrmVerUsuario(usuarioId);
            frmVerUsuario.ShowDialog();
        }

        private void AbrirFormularioEditarUsuario()
        {
            var frmEditarUsuario = new FrmEditarUsuario();

            if (frmEditarUsuario.ShowDialog() == DialogResult.OK)
            {
                ActualizarListaUsuarios(_usuarioServicio.ObtenerListaUsuarios());
            }
        }

        private void ConfirmarEliminarUsuario(int id, string usuario)
        {
            if (MessageBox.Show($"¿Está seguro de querer eliminar al usuario {usuario.ToUpper()}?", "Eliminar usuario: confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (_usuarioServicio.EliminarUsuario(id) > 0)
                {
                    ActualizarListaUsuarios(_usuarioServicio.ObtenerListaUsuarios());
                }
            }
        }
    }
}
