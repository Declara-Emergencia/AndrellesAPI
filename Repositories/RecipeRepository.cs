using API_Andreia_Leles.Entities;
using API_Andreia_Leles.Repositories.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;

namespace API_Andreia_Leles.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public List<Recipe> RecipeList { get; set; }

        public RecipeRepository()
        {
            RecipeList = new List<Recipe>();
        }

        public IEnumerable<Recipe> GetAll()
        {
            return RecipeList.Any() ? RecipeList : null;
        }

        public bool Insert(Recipe recipe)
        {
           if (recipe != null)
            {
                RecipeList.Add(recipe);
                return true;
            }

            return false;
        }
    }
}
