using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public FrmUsuarios()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
        }

        private async void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmAgregarUsuario = new FrmAgregarUsuario();

            if (frmAgregarUsuario.ShowDialog() == DialogResult.OK)
            {
                Task task = ActualizarLista();
                task.Start();
                await task;
            }
        }

        private async Task ActualizarLista()
        {
            var usuarios = await _usuarioServicio.ObtenerUsuarios();

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

        private async void FrmUsuarios_Load(object sender, EventArgs e)
        {         
            await Task.Run(ActualizarLista);
        }
    }
}
