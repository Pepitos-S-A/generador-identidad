using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Rol
    {
        [BsonId]
        //public int? RolId { get; set; }
        public string RolId { get; set; } = string.Empty;

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}
