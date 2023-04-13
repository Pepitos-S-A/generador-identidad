using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Duisv.Modelos
{
    public class Ciudadano
    {
        private string genero = string.Empty;
        private string tipoSangre = string.Empty;

        [BsonId]
        public string CiudadanoId { get; set; }

        [BsonElement("nombres")]
        public string Nombres { get; set; } = string.Empty;

        [BsonElement("apellidos")]
        public string Apellidos { get; set; } = string.Empty;

        [BsonElement("conocido_por")]
        public string ConocidoPor { get; set; } = string.Empty;

        [BsonElement("genero")]
        public string Genero
        {
            get { return genero; }
            set
            {
                if (value.Equals("M"))
                {
                    genero = "Masculino";
                }
                else
                {
                    genero = "Femenino";
                }
            }
        }

        [BsonElement("ciudadano_por")]
        public string CiudadanoPor { get; set; } = string.Empty;

        [BsonElement("fecha_nacimiento")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaNacimiento { get; set; }

        [BsonElement("residencia")]
        public string Residencia { get; set; } = string.Empty;

        [BsonElement("estado_familiar")]
        public string EstadoFamiliar { get; set; } = string.Empty;

        [BsonElement("profesion")]
        public string Profesion { get; set; } = string.Empty;

        [BsonElement("tipo_sangre")]
        public string TipoSangre 
        { 
            get
            {
                if (string.IsNullOrEmpty(tipoSangre))
                {
                    return "-- Seleccionar --";
                }
                else
                {
                    return tipoSangre;
                }
            }
            set
            {
                if (value.Equals("-- Seleccionar --"))
                {
                    tipoSangre = string.Empty;
                }
                else
                {
                    tipoSangre = value;
                }
            }
        }

        [BsonElement("nombre_madre")]
        public string NombreMadre { get; set; } = string.Empty;

        [BsonElement("nombre_padre")]
        public string NombrePadre { get; set; } = string.Empty;

        [BsonElement("nombre_conyugue")]
        public string NombreConyugue { get; set; } = string.Empty;

        [BsonElement("municipio_nacimiento")]
        public string MunicipioNacimiento { get; set; } = string.Empty;

        [BsonElement("departamento_nacimiento")]
        public string DepartamentoNacimiento { get; set; } = string.Empty;

        [BsonElement("municipio_residencia")]
        public string MunicipioResidencia { get; set; } = string.Empty;

        [BsonElement("departamento_residencia")]
        public string DepartamentoResidencia { get; set; } = string.Empty;

        [BsonElement("documento_id")]
        [BsonRepresentation(BsonType.Int32)]
        public int? DocumentoId { get; set; }

        [BsonElement("numero_documento")]
        public string NumeroDocumento { get; set; } = string.Empty;
    }
}
