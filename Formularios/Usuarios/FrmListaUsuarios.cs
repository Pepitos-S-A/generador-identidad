using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;
using PagedList;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmListaUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly Usuario _usuario;

        private int _numeroPagina;
        private List<Usuario> _usuarios;
        private IPagedList<Usuario> _usuariosPaginados;

        public FrmListaUsuarios(Usuario usuario)
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
            _usuario = usuario;
            _numeroPagina = 1;
        }

        private bool AutorizarUsuario()
        {
            return _usuario.Rol.Equals("Administrador");
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarUsuario();
        }

        private void MostrarListadoUsuarios(List<Usuario> usuarios, int numeroPagina = 1, int cantidadMostrar = 5)
        {
            _usuarios = usuarios;
            _numeroPagina = numeroPagina;

            DgvUsuarios.Rows.Clear();

            if (_usuarios.Count > 0 && _usuarios != null)
            {
                _usuariosPaginados = _usuarios.ToPagedList(numeroPagina, cantidadMostrar);

                foreach (var usuario in _usuariosPaginados)
                {
                    DgvUsuarios.Rows.Add(usuario.UsuarioId, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.NombreUsuario, usuario.Rol);
                }

                DgvUsuarios.ClearSelection();

                BtnPaginaAnterior.Enabled = _usuariosPaginados.HasPreviousPage;
                BtnPaginaSiguiente.Enabled = _usuariosPaginados.HasNextPage;
                LblPaginacion.Text = $"Página {_numeroPagina} de {_usuariosPaginados.PageCount}";
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarListadoUsuarios(_usuarioServicio.ObtenerListaUsuarios());
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
                        AbrirFormularioEditarUsuario(usuarioId );
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
        
        private void AbrirFormularioAgregarUsuario()
        {
            if (AutorizarUsuario())
            {
                var frmAgregarUsuario = new FrmAgregarUsuario();

                if (frmAgregarUsuario.ShowDialog() == DialogResult.OK)
                {
                    MostrarListadoUsuarios(_usuarioServicio.ObtenerListaUsuarios());
                }
            }
            else
            {
                MessageBox.Show("Su usuario no tiene autorización para realizar esta operación.", "Usuarios: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }            
        }

        private void AbrirFormularioEditarUsuario(int usuarioId)
        {
            if (AutorizarUsuario())
            {
                var frmEditarUsuario = new FrmEditarUsuario(usuarioId);

                if (frmEditarUsuario.ShowDialog() == DialogResult.OK)
                {
                    MostrarListadoUsuarios(_usuarioServicio.ObtenerListaUsuarios());
                }
            }
            else
            {
                MessageBox.Show("Su usuario no tiene autorización para realizar esta operación.", "Usuarios: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }            
        }

        private void ConfirmarEliminarUsuario(int id, string usuario)
        {
            if (AutorizarUsuario())
            {
                if (MessageBox.Show($"¿Está seguro de querer eliminar al usuario {usuario.ToUpper()}?", "Eliminar usuario: confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (_usuarioServicio.EliminarUsuario(id) > 0)
                    {
                        MostrarListadoUsuarios(_usuarioServicio.ObtenerListaUsuarios());
                    }
                }
            }
            else
            {
                MessageBox.Show("Su usuario no tiene autorización para realizar esta operación.", "Usuarios: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (_usuariosPaginados.HasPreviousPage)
            {
                MostrarListadoUsuarios(_usuarios, --_numeroPagina);
            }
        }

        private void BtnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            if (_usuariosPaginados.HasNextPage)
            {
                MostrarListadoUsuarios(_usuarios, ++_numeroPagina);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var busqueda = TBxBusqueda.Text;

            switch (BtnBuscar.Text)
            {
                case "Buscar":
                    MostrarListadoUsuarios(_usuarioServicio.ObtenerResultadosBusqueda(busqueda));
                    BtnBuscar.Text = "Borrar";
                    break;
                case "Borrar":
                    MostrarListadoUsuarios(_usuarioServicio.ObtenerListaUsuarios());
                    TBxBusqueda.Text = string.Empty;
                    BtnBuscar.Text = "Buscar";
                    break;
                default:
                    break;
            }
        }
    }
}
