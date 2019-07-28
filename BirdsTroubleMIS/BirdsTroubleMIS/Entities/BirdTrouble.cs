using BirdsTroubleMIS.Consts;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace BirdsTroubleMIS.Entities
{
    public class BirdTrouble : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public VoltageLevel KV { get; set; }

        public string LineId { get; set; }

        public string TowerNo { get; set; }

        public string Position { get; set; }

        public bool IsDisposed { get; set; }

        public List<string> Pictures { get; set; }
    }
}
