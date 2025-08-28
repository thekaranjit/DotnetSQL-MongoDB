﻿
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace sqlapp.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ProductID")]
        public int ProductID { get; set; }

        [BsonElement("ProductName")]
    public string? ProductName { get; set; }

        [BsonElement("Quantity")]
        public int Quantity { get; set; }
    }
}
