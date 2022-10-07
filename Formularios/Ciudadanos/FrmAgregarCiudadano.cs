using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;
using Duisv.Validaciones;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmAgregarCiudadano : Form
    {
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipioServicio;
        private readonly CiudadanoServicio _ciudadanoServicio;

        public FrmAgregarCiudadano()
        {
            InitializeComponent();

            _departamentoServicio = new DepartamentoServicio();
            _municipioServicio = new MunicipioServicio();
            _ciudadanoServicio = new CiudadanoServicio();
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
            ciudadanoBindingSource.DataSource = new Ciudadano();

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

        private bool ValidarDatosCiudadano(Ciudadano ciudadano)
        {
            var valido = true;
            var validador = new AgregarCiudadanoValidador();
            var resultado = validador.Validate(ciudadano);
            var errores = resultado.Errors;

            if (!resultado.IsValid)
            {
                foreach (var error in errores)
                {
                    MessageBox.Show(error.ErrorMessage, "Agregar ciudadano: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                valido = false;
            }

            return valido;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ciudadanoBindingSource.EndEdit();

            var ciudadano = ciudadanoBindingSource.Current as Ciudadano;

            if (ciudadano != null)
            {
                if (ValidarDatosCiudadano(ciudadano))
                {
                    if (_ciudadanoServicio.AgregarCiudadano(ciudadano) > 0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}