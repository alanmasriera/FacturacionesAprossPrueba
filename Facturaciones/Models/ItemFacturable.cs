﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;

namespace MongoDbAPI.Models
{
    public class ItemFacturable
    {
        //[BsonId]
        //public ObjectId Id { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string numero_afiliado { get; set; }
        public string numero_evento { get; set; }
        public int numero_autorizacion { get; set; }
        public int tipo_episodio { get; set; }
        public int id_prestador { get; set; }
        public string desc_prestador { get; set; }
        public int id_efector { get; set; }
        public string nombre_efector { get; set; }
        public int id_prescriptor { get; set; }
        public string nombre_prescriptor { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_egreso { get; set; }
        public int via_ingreso { get; set; }
        public int estado_salida { get; set; }
        public string diagnosticos { get; set; }//[] Diagnostico diagnosticos { get; set; }
        public DateTime fecha_intervencion { get; set; }
        public float tiempo_intervencion { get; set; }
        public float tiempo_ventilacion { get; set; }
        public string autorizacion { get; set; }
        public string codigo_prest { get; set; }
        public string descripcion_prest { get; set; }
        public DateTime fecha_prestacion { get; set; }
        public float cantidad { get; set; }
}
}
