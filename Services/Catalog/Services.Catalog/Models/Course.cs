using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Services.Catalog.Models
{
    public class Course
    {
        [BsonId] //dbye bağladım.
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string UserId { get; set; } //Id string = güvenli
        public string CourseName { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)] //tipini belli ediyorum.
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; } //feature tablosunu bağladım.

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore] //MongodbDeki collectionlara birer satır olarak yansıtırken gözardı etmek için.
        public Category Category { get; set; }

    }
}
