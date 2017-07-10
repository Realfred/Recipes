using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesWeb.Services
{
    public interface IRecipeService

    {
        void AddIngredient(Ingredient ingredient);
        List<Ingredient> GetIngredients();
        void AddRecipe(Recipe recipe);
        Recipe GetRecipeById(int Id);
        List<Recipe> GetRecipes();
        List<Recipe> FindRecipes(string recipeName);
    }
}
