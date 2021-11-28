using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("RecipeCategory_Id")]
        public RecipeCategory RecipeCategory { get; set; }
        public int RecipeCategory_Id { get; set; }

        public IdentityUser User { get; set; }

        public IEnumerable<RecipeIngredient> RecipesIngredients { get; set; }

    }
}
