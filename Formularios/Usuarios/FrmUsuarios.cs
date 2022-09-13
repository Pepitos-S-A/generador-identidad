using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duisv.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmAgregarUsuario = new FrmAgregarUsuario();

            if (frmAgregarUsuario.ShowDialog() == DialogResult.OK)
            {
                // Actualizar lista de usuarios
            }
        }

        private void PBxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            DgvUsuarios.Rows.Add();
        }
    }
}
