using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Duisv.Modelos
{
    public class Documento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DocumentoId { get; set; }

        [BsonElement("fecha_expedicion")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime FechaExpedicion { get; set; }

        [BsonElement("municipio_expedicion")]
        public string MunicipioExpedicion { get; set; } = string.Empty;

        [BsonElement("departamento_expedicion")]
        public string DepartamentoExpedicion { get; set; } = string.Empty;

        [BsonElement("fecha_expiracion")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime FechaExpiracion { get; set; }

        [BsonElement("numero")]
        public string Numero { get; set; } = string.Empty;

        [BsonElement("tipo_sangre")]
        public string TipoTramite { get; set; } = string.Empty;

        [BsonElement("codigo_zona")]
        public string CodigoZona { get; set; } = string.Empty;

        [BsonElement("numero_folio")]
        public string NumeroFolio { get; set; } = string.Empty;
    }
}
