using RecipesWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecipesWeb.Controllers
{
    public class RecipeApiController : ApiController
    {
        private IRecipeService _recipeService;

        RecipeApiController()
        {
            _recipeService = new RecipeService();
        }

        [Route("api/ingredients")]
        public List<Ingredient> GetIngredients()
        {
            var ingredients = _recipeService.GetIngredients();
            return ingredients; 
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
