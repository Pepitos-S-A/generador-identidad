using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Rol
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //public int? RolId { get; set; }
        public string RolId { get; set; } = string.Empty;

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}
