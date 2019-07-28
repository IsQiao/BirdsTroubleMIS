using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BirdsTroubleMIS.Entities
{
    public class Line : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
