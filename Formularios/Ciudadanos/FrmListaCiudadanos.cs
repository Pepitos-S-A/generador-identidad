using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;
using PagedList;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmListaCiudadanos : Form
    {
        private List<Ciudadano> _ciudadanos;
        private int _numeroPagina;
        private IPagedList<Ciudadano> _ciudadanosPaginados;

        private readonly CiudadanoServicio _ciudadanoServicio;

        public FrmListaCiudadanos()
        {
            InitializeComponent();

            _numeroPagina = 1;
            _ciudadanoServicio = new CiudadanoServicio();

        }

        private void BtnAgregarCiudadano_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarCiudadno();
        }

        private void AbrirFormularioAgregarCiudadno()
        {
            var frmAgregarCiudadano = new FrmAgregarCiudadano();

            if (frmAgregarCiudadano.ShowDialog() == DialogResult.OK)
            {
                MostrarListado(_ciudadanoServicio.ObtenerListaCiudadanos());
            }
        }

        private void FrmListaCiudadanos_Load(object sender, EventArgs e)
        {
            MostrarListado(_ciudadanoServicio.ObtenerListaCiudadanos());
        }

        private void MostrarListado(List<Ciudadano> ciudadanos, int numeroPagina = 1, int cantidadMostrar = 5)
        {
            _ciudadanos = ciudadanos;
            _numeroPagina = numeroPagina;
            DgvCiudadanos.Rows.Clear();

            if (_ciudadanos.Count > 0 && _ciudadanos != null)
            {
                _ciudadanosPaginados = _ciudadanos.ToPagedList(numeroPagina, cantidadMostrar);

                ciudadanoBindingSource.DataSource = _ciudadanosPaginados;

                BtnPaginaAnterior.Enabled = _ciudadanosPaginados.HasPreviousPage;
                BtnPaginaSiguiente.Enabled = _ciudadanosPaginados.HasNextPage;
                LblPaginacion.Text = $"Página {_numeroPagina} de {_ciudadanosPaginados.PageCount}";
            }
        }

        private void DgvCiudadanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var ciudadanoId = dataGridView.Rows[e.RowIndex].Cells["ciudadanoIdDataGridViewTextBoxColumn"].Value.ToString();

                switch (e.ColumnIndex)
                {
                    case 20:
                        AbrirFormularioVer(ciudadanoId);
                        break;
                    case 21:
                        AbrirFormularioEditar(ciudadanoId);
                        break;
                    case 22:
                        ConfirmarEliminar(ciudadanoId);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ConfirmarEliminar(string ciudadanoId)
        {
            if (MessageBox.Show($"¿Está seguro de querer eliminar al ciudadano?", "Eliminar ciudadano: confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (_ciudadanoServicio.EliminarCiudadano(ciudadanoId) > 0)
                {
                    MostrarListado(_ciudadanoServicio.ObtenerListaCiudadanos());
                }
            }
        }

        private void AbrirFormularioEditar(string ciudadanoId)
        {
            var frmEditarCiudadano = new FrmEditarCiudadano(ciudadanoId);

            if (frmEditarCiudadano.ShowDialog() == DialogResult.OK)
            {
                MostrarListado(_ciudadanoServicio.ObtenerListaCiudadanos());
            }
        }

        private void AbrirFormularioVer(string ciudadanoId)
        {
            var frmVerCiudadano = new FrmVerCiudadano(ciudadanoId);
            frmVerCiudadano.ShowDialog();
        }

        private void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (_ciudadanosPaginados.HasPreviousPage)
            {
                MostrarListado(_ciudadanos, --_numeroPagina);
            }
        }

        private void BtnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            if (_ciudadanosPaginados.HasNextPage)
            {
                MostrarListado(_ciudadanos, ++_numeroPagina);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var busqueda = TBxBusqueda.Text;

            switch (BtnBuscar.Text)
            {
                case "Buscar":
                    MostrarListado(_ciudadanoServicio.ObtenerResultadoBusqueda(busqueda));
                    BtnBuscar.Text = "Borrar";
                    break;
                case "Borrar":
                    MostrarListado(_ciudadanoServicio.ObtenerListaCiudadanos());
                    TBxBusqueda.Text = string.Empty;
                    BtnBuscar.Text = "Buscar";
                    break;
                default:
                    break;
            }
        }
    }
}