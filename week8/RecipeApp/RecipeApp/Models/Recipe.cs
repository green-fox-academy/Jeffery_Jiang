using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public long RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
