using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.Models;
using RecipeApp.Services;

namespace RecipeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeServer recipeServer;

        public HomeController(IRecipeServer recipeServer)
        {
            this.recipeServer = recipeServer;
        }

        public  IActionResult Index()
        {
             var recipeList = recipeServer.FindAll();
            return View(recipeList);
        }

        public async Task<IActionResult> Delete(long id)
        {
            var recipe = await recipeServer.FindByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditPage(long id)
        {
            var recipe = await recipeServer.FindByIdAsync(id);
            string ingredientString = "";
            foreach (var element in recipe.Ingredients)
            {
                ingredientString += $"{element.Amount} {element.Unit} {element.Name}\n";
            }

            ViewBag.Igredients = ingredientString;
            return View(recipe);
        }

        public async Task<IActionResult> EditRecip(Recipe recipe,long id,string ingredientText)
        {
            var ingredients = await recipeServer.CreateIngredientList(ingredientText);
            var _recipe = await recipeServer.FindByIdAsync(id);
            _recipe.Name = recipe.Name;
            _recipe.Description = recipe.Description;
            _recipe.Ingredients.Clear();
            _recipe.Ingredients = ingredients;

            await recipeServer.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
