using System;
using System.Windows.Forms;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmElegirPartidaNacimiento : Form
    {
        public string RutaDocumento { get; set; }

        public FrmElegirPartidaNacimiento()
        {
            InitializeComponent();
        }

        private void BtnImportarDocumento_Click(object sender, EventArgs e)
        {
            OfdSeleccionarDocumento.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (OfdSeleccionarDocumento.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF.src = OfdSeleccionarDocumento.FileName;
            }
        }

        private void BtnGuardarDocumento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OfdSeleccionarDocumento.FileName))
            {
                RutaDocumento = OfdSeleccionarDocumento.FileName;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
