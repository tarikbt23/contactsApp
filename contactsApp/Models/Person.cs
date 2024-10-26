using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public required string Name { get; set; }

    [BsonElement("surname")]
    public string? Surname { get; set; }

    [BsonElement("phoneNumber")]
    public required string PhoneNumber { get; set; }

    [BsonElement("photo")]
    public string? Photo { get; set; }
}