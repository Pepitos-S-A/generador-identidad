using System;
using System.Windows.Forms;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PBxMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
