using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dal
{
    public class User
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("userType")]
        private userType userType { get; set; }
        [BsonElement("firstName")]
        public string firstName { get; set; }
        [BsonElement("lastName")]
        public string lastName { get; set; }
        [BsonElement("email")]
        public string email { get; set; }
        [BsonElement("password")]
        public string password { get; set; }
        public User() { }   

    }
}
