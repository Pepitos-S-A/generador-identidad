using System;

namespace Duisv.Modelos
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public string MunicipioExpedicion { get; set; } = string.Empty;
        public string DepartamentoExpedicion { get; set; } = string.Empty;
        public DateTime FechaExpiracion { get; set; }
        public string Numero { get; set; } = string.Empty;
        public string TipoTramite { get; set; } = string.Empty;
        public string CodigoZona { get; set; } = string.Empty;
        public string NumeroFolio { get; set; } = string.Empty;
    }
}
