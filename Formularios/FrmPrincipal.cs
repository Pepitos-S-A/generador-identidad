using System;
using System.Windows.Forms;
using Duisv.Formularios.Usuarios;

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

        private void CerrarFormulario()
        {
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void PBxMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}
