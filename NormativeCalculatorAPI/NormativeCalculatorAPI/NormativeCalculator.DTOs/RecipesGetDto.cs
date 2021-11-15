using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
    public class RecipesGetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime Created { get; set; }

        public int RecipeCategory_Id { get; set; }
    
        public IEnumerable<Recipe_IngredientsGetDto> Recipes_Ingredients { get; set; }


    }
}
