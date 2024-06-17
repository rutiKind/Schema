using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class userType
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Discreption")]
        public string Discreption { get; set; }

    }
}
