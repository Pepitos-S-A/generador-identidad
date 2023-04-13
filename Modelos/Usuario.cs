using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Duisv.Modelos
{
    public class Usuario
    {
        [BsonId]
        public string UsuarioId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [BsonElement("apellido")]
        public string Apellido { get; set; } = string.Empty;

        [BsonElement("correo_electronico")]
        public string CorreoElectronico { get; set; } = string.Empty;

        [BsonElement("fecha_nacimiento")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaNacimiento { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; } = string.Empty;

        [BsonElement("telefono")]
        public string Telefono { get; set; } = string.Empty;

        [BsonElement("numero_usuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [BsonElement("clave")]
        public string Clave { get; set; } = string.Empty;

        [BsonElement("repetir_clave")]
        public string RepetirClave { get; set; } = string.Empty;

        [BsonElement("rol")]
        public string Rol { get; set; } = string.Empty;

        [BsonElement("rol_id")]
        public string RolId { get; set; } = string.Empty;
    }
}
