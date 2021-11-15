using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
    public class RecipesAddRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public int RecipeCategory_Id { get; set; }

        public IdentityUser User { get; set; }

        public string UserId { get; set; }


        //public List<int> Ingredients { get; set; }
        public List<Recipes_Ingredients> Ingredients { get; set; }


    }
}
