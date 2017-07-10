using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesWeb.Services
{
    public class RecipeService : IRecipeService
    {
        private IDbContext Context
        {
            get
            {
                return new DbContext().ConnectionStringName("Db", new SqlServerProvider());

            }
        }
        public void AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> FindRecipes(string recipeName)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetIngredients()
        {
            var ingredients = Context.Sql("Select * From Ingredient").QueryMany<Ingredient>();
            return ingredients;
        }

        public Recipe GetRecipeById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetRecipes()
        {
            throw new NotImplementedException();
        }
    }
}