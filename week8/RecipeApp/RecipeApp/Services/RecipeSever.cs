using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RecipeApp.Models;

namespace RecipeApp.Services
{
    public class RecipeSever : IRecipeServer
    {
        private readonly ApplicationContext applicationContext;

        public RecipeSever(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task<ICollection<Ingredient>> CreateIngredientList(string ingredientText)
        {
            var ingredientList = new List<Ingredient>();
            var ingredientArray = ingredientText.Split('\n');
            foreach (var element in ingredientArray)
            {
                var ingredientString = element.Split(' ');
                if (decimal.TryParse(ingredientString[0], out decimal result))
                {
                    var ingredient = new Ingredient()
                    {
                        Amount = result,
                        Unit = ingredientString[1],
                        Name = ingredientString.Skip(2).Join(" ")
                    };

                    ingredientList.Add(ingredient);
                    
                    
                }
                else if(element!="")
                {
                    var ingredient=new Ingredient()
                    {
                        Name=element
                    };
                    ingredientList.Add(ingredient);
                    
                }
               
            }

            return ingredientList;
        }

        public IEnumerable<Recipe> FindAll()
        {
            return applicationContext.Recipes
                .Include(r => r.Ingredients)
                .ToList();
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            await applicationContext.Recipes.AddAsync(recipe);
            await applicationContext.SaveChangesAsync();
        }

        public async Task<Recipe> FindByIdAsync(long id)
        {
            return await applicationContext.Recipes.Include(r => r.Ingredients)
                .FirstOrDefaultAsync(r => r.RecipeId == id);
        }

        public async Task SaveAsync()
        {
            await applicationContext.SaveChangesAsync();
        }
    }
}
