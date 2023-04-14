using MongoDB.Bson.Serialization.Attributes;

namespace Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] //mongo db tutulan veri formatını stringe çeviştiricek ben string gönderdiğimde de objectId ye dönüştürecek.
        public string Id { get; set; }
        public string CategoryName { get; set; }
    }
}
