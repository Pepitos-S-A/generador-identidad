using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmAgregarCiudadano : Form
    {
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;

        public FrmAgregarCiudadano()
        {
            InitializeComponent();

            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
        }

        private void MostrarListaDespartamentos(List<Departamento> departamentos, ref ComboBox comboBox)
        {

            comboBox.BindingContext = new BindingContext();            
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "DepartamentoId";
            comboBox.DataSource = departamentos;
        }

        private void FrmAgregarCiudadano_Load(object sender, EventArgs e)
        {
            var departamentos = _departamentoServicio.ObtenerListaDepartamentos();
            departamentos.Insert(0, new Departamento { DepartamentoId = 0, Nombre = "-- Seleccionar --" });

            MostrarListaDespartamentos(departamentos, ref departamentoResidenciaComboBox);
            MostrarListaDespartamentos(departamentos, ref departamentoNacimientoComboBox);
        }

        private void departamentoNacimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioNacimientoComboBox, departamentoId);
            }
        }

        private void MostrarListaMunicipios(ref ComboBox comboBox, int departamentoId)
        {
            var municipios = _municipioServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId);

            comboBox.BindingContext = new BindingContext();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "MunicipioId";
            comboBox.DataSource = municipios;
        }

        private void departamentoResidenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamentoId = Convert.ToInt32(((ComboBox)sender).SelectedValue);

            if (departamentoId != 0)
            {
                MostrarListaMunicipios(ref municipioResidenciaComboBox, departamentoId);
            }
        }
    }
}