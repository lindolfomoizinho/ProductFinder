using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductFinder.Model.Domain;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Name")]
    public string Name { get; set; } = null!;
    [BsonElement("Price")]
    public decimal Price { get; set; }
    public int Quantity { get; set; }

}