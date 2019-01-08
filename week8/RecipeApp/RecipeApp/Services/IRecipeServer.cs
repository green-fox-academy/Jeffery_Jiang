using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Models;

namespace RecipeApp.Services
{
    public interface IRecipeServer
    {
        Task<ICollection<Ingredient>> CreateIngredientList(string ingredientText);
        IEnumerable<Recipe> FindAll();
        Task AddRecipeAsync(Recipe recipe);
        Task<Recipe> FindByIdAsync(long id);
        Task SaveAsync();
    }
}
