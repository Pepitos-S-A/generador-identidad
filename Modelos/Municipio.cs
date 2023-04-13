using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Municipio
    {
        [BsonId]
        public string MunicipioId { get; set; } = 0;

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [BsonElement("departamento_id")]
        public int? DepartamentoId { get; set; }
    }
}
