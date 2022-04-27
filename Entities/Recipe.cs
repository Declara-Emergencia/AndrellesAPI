using API_Andreia_Leles.Entities.Interfaces;
using LiteDB;

namespace API_Andreia_Leles.Entities
{
    public class Recipe : IPersistable
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonField]
        public string? RecipeName { get; set; }
    }
}
