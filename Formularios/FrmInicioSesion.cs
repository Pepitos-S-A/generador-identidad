using System;
using System.Windows.Forms;

namespace Duisv.Formularios
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PBxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PBxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PBxCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void PBxMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
