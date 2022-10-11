using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmEditarCiudadano : Form
    {
        private readonly CiudadanoServicio _ciudadanoServicio;
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;
        private readonly int _ciudadanoId;

        public FrmEditarCiudadano(int ciudadanoId)
        {
            InitializeComponent();

            _ciudadanoServicio = new CiudadanoServicio();
            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
            _ciudadanoId = ciudadanoId;
        }

        private void MostrarDatos()
        {
            var departamentos = _departamentoServicio.ObtenerListaDepartamentos();

            MostrarListaDespartamentos(departamentos, ref departamentoNacimientoComboBox);
            MostrarListaDespartamentos(departamentos, ref departamentoResidenciaComboBox);

            var ciudadano = _ciudadanoServicio.ObtenerCiudadanoPorId(_ciudadanoId);

            if (ciudadano != null)
            {
                ciudadanoBindingSource.DataSource = ciudadano;
            }

            var nombres = ((Ciudadano)ciudadanoBindingSource.Current).Nombres;
            var apellidos = ((Ciudadano)ciudadanoBindingSource.Current).Apellidos;


            LblTituloVentana.Text = $"Editar datos del ciudadano {nombres.ToUpper()} {apellidos.ToUpper()}";
        }

        private void MostrarListaMunicipios(ref ComboBox comboBox, int departamentoId)
        {
            var municipios = _municipioServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId);

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "MunicipioId";
            comboBox.DataSource = municipios;
        }

        private void MostrarListaDespartamentos(List<Departamento> departamentos, ref ComboBox comboBox)
        {

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "DepartamentoId";
            comboBox.DataSource = departamentos;
        }

        private void FrmEditarCiudadano_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void DepartamentoNacimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioNacimientoComboBox, departamentoId);
            }
        }

        private void DepartamentoResidenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioResidenciaComboBox, departamentoId);
            }
        }
    }
}
