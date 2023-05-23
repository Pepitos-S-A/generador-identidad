using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Modelos;
using Microsoft.Reporting.WinForms;

namespace Duisv.Formularios.Ciudadanos
{
    public partial class FrmMostrarIdentificacion : Form
    {
        private readonly Empleado _ciudadano;
        private readonly Documento _documento;

        public List<Empleado> ciudadanos;

        public FrmMostrarIdentificacion(Empleado ciudadano, Documento documento)
        {
            InitializeComponent();

            _ciudadano = ciudadano;
            _documento = documento; 

            ciudadanos = new List<Empleado>();
        }

        private void FrmMostrarDui_Load(object sender, EventArgs e)
        {
            ciudadanos.Add(_ciudadano);

            RpvDui.LocalReport.DataSources.Clear();
            RpvDui.LocalReport.EnableExternalImages = true;
            RpvDui.LocalReport.DisplayName = "Documento de identidad";
            RpvDui.LocalReport.SetParameters(new List<ReportParameter>()
            {
                new ReportParameter("Genero", _ciudadano.Genero == "Masculino" ? "M" : "F"),
                new ReportParameter("LugarNacimiento", string.Concat(_ciudadano.MunicipioNacimiento, ", ", _ciudadano.DepartamentoNacimiento)),
                new ReportParameter("FechaExpedicion", _documento.FechaExpedicion.ToShortDateString()),
                new ReportParameter("LugarExpedicion", string.Concat(_documento.MunicipioExpedicion, ", ", _documento.DepartamentoExpedicion)),
                new ReportParameter("FechaExpiracion", _documento.FechaExpiracion.ToShortDateString()),
                new ReportParameter("FechaNacimiento", _ciudadano.FechaNacimiento.Value.ToShortDateString()),
                new ReportParameter("NumeroUnicoIdentidad", long.Parse(_ciudadano.NumeroDocumento).ToString("000000000")),
                new ReportParameter("RutaFoto", $@"file:\{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Fotos\{_ciudadano.NumeroDocumento}.png"),
                new ReportParameter("RutaFirma", $@"file:\{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\PepitosSA\Empleados\Firmas\{_ciudadano.NumeroDocumento}.png"),
                new ReportParameter("TipoTramite", _documento.TipoTramite),
                new ReportParameter("CodigoZona", _documento.CodigoZona),
                new ReportParameter("NumeroFolio", _documento.NumeroFolio)
            });
            RpvDui.SetDisplayMode(DisplayMode.PrintLayout);
            RpvDui.ZoomMode = ZoomMode.Percent;
            RpvDui.ZoomPercent = 100;
            RpvDui.LocalReport.DataSources.Add(new ReportDataSource("CiudadanoDataSet", ciudadanos));
            RpvDui.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
