﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BirdsTroubleMIS.Entities
{
    public interface IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
    }
}
