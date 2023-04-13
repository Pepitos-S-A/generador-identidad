﻿using MongoDB.Bson.Serialization.Attributes;

namespace Duisv.Modelos
{
    internal class Departamento
    {
        [BsonId]
        public string DepartamentoId { get; set; } = 0;

        [BsonElement("nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}
