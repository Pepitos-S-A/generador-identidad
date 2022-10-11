using System;
using System.Windows.Forms;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmEditarCiudadano : Form
    {
        private readonly CiudadanoServicio _ciudadanoServicio;

        public FrmEditarCiudadano(int ciudadanoId)
        {
            InitializeComponent();

            _ciudadanoServicio = new CiudadanoServicio();

            var ciudadano = _ciudadanoServicio.ObtenerCiudadanoPorId(ciudadanoId);

            if (ciudadano != null)
            {
                ciudadanoBindingSource.DataSource = ciudadano;
            }
        }

        private void FrmEditarCiudadano_Load(object sender, EventArgs e)
        {
            var nombres = ((Ciudadano)ciudadanoBindingSource.Current).Nombres;
            var apellidos = ((Ciudadano)ciudadanoBindingSource.Current).Apellidos;

            LblTituloVentana.Text = $"Editar datos del ciudadano {nombres.ToUpper()} {apellidos.ToUpper()}";
        }
    }
}
