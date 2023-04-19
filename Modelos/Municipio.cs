using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Municipio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MunicipioId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [BsonElement("departamento_id")]
        public string DepartamentoId { get; set; }
    }
}
