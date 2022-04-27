using LiteDB;

namespace API_Andreia_Leles.Entities.Interfaces
{
    public interface IPersistable
    {   
        public ObjectId Id { get; set; }
    }
}
