using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RecipeApp.Models
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        public decimal? Amount { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Recipe Recipe { get; set; }
    }
}
