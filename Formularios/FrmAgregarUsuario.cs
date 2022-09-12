﻿using System;
using System.Windows.Forms;

namespace Duisv.Formularios
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

        private void PBxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PBxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
