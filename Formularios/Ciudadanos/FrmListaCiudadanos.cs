using System;
using System.Windows.Forms;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmListaCiudadanos : Form
    {
        public FrmListaCiudadanos()
        {
            InitializeComponent();
        }

        private void BtnAgregarCiudadano_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarCiudadno();
        }

        private void AbrirFormularioAgregarCiudadno()
        {
            var frmAgregarCiudadano = new FrmAgregarCiudadano();
            frmAgregarCiudadano.ShowDialog();
        }
    }
}
