using System;
using System.Windows.Forms;

namespace Duisv.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditarPerfil_Click(object sender, EventArgs e)
        {
            var frmEditarPerfil = new FrmEditarPerfil();
            frmEditarPerfil.ShowDialog();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmAgregarUsuario = new FrmAgregarUsuario();
            frmAgregarUsuario.ShowDialog();
        }
    }
}
