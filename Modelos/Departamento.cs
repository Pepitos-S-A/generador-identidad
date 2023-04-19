﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Departamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DepartamentoId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}
