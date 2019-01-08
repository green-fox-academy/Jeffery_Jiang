using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.Models;
using RecipeApp.Services;

namespace RecipeApp.Controllers
{
    public class CreateController : Controller
    {
        private readonly IRecipeServer recipeServer;

        public CreateController(IRecipeServer recipeServer)
        {
            this.recipeServer = recipeServer;
        }

        public async Task<IActionResult> CreateRecipe()
        {
            return View();
        }

        public async Task<IActionResult> Create(Recipe recipe,string ingredientText)
        {

            var ingredients = await recipeServer.CreateIngredientList(ingredientText);
            var _recipe= new Recipe()
            {
                Description = recipe.Description,
                Ingredients = ingredients,
                Name = recipe.Name
            };
            await recipeServer.AddRecipeAsync(_recipe);
            return Redirect("/");
        }
        
    }
}