using API_Andreia_Leles.Entities;
using System.Collections.Generic;

namespace API_Andreia_Leles.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAll();
        bool Insert(Recipe recipe);
    }
}
