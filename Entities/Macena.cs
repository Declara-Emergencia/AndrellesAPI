using API_Andreia_Leles.Entities.Interfaces;
using LiteDB;

namespace API_Andreia_Leles.Entities
{
    public class Macena : IPersistable
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonField]
        public string? PhoneNumber { get; set; }

        [BsonField]
        public int DickSize { get; set; }
    }
}
