using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
