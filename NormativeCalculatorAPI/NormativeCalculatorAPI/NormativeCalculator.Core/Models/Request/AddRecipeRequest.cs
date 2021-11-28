using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core;
using System;
using System.Collections.Generic;

namespace NormativeCalculator.Core.Models.Request
{
    public class AddRecipeRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public int RecipeCategory_Id { get; set; }

        public IdentityUser User { get; set; }

        public string UserId { get; set; }


        //public List<int> Ingredients { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }


    }
}
