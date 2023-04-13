using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Rol
    {
        [BsonId]
        public int? RolId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}
