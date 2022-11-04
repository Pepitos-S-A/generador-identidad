using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Duisv.Formularios
{
    public partial class FrmTomarFoto : Form
    {

        private readonly FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;
        private PictureBox _pictureBox;

        public FrmTomarFoto(ref PictureBox pictureBox)
        {
            InitializeComponent();

            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _pictureBox = pictureBox;
        }

        private void CargarDatosCamaras()
        {
            CbBxCamaras.Items.Add("-- Seleccionar --");

            foreach (FilterInfo filterInfo in _filterInfoCollection)
            {
                CbBxCamaras.Items.Add(filterInfo.Name);
            }

            CbBxCamaras.SelectedIndex = 0;
        }

        private void BtnIniciar_Click(object sender, System.EventArgs e)
        {
            if (CbBxCamaras.SelectedIndex != 0)
            {
                _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[CbBxCamaras.SelectedIndex - 1].MonikerString);
                _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                _videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("Seleccione una cámara de la lista", "Captura foto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            PBxCamara.Image = (Bitmap)e.Frame.Clone();
        }

        private void FrmTomarFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice != null)
            {
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.Stop();
                }
            }
        }

        private void FrmTomarFoto_Load(object sender, System.EventArgs e)
        {
            CargarDatosCamaras();
        }

        private void BtnCapturar_Click(object sender, System.EventArgs e)
        {
            if (_videoCaptureDevice.IsRunning && _videoCaptureDevice != null)
            {
                PBxCaptura.Image = PBxCamara.Image;
                BtnGuardar.Enabled = true;
            }
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (PBxCaptura.Image != null)
                {
                    _pictureBox.Image = PBxCaptura.Image;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio el siguiente error al seleccionar la foto: \n{ex.Message}", "Capturar foto: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
