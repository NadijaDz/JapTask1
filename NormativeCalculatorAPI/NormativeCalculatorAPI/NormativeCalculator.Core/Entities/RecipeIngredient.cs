using NormativeCalculator.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormativeCalculator.Core
{
    public class RecipeIngredient
    {

        [ForeignKey("Recipe_Id")]
        public Recipe Recipe { get; set; }
        public int Recipe_Id { get; set; }

        [ForeignKey("Ingredient_Id")]
        public Ingredient Ingredient { get; set; }
        public int Ingredient_Id { get; set; }

        public MeasureUnit MeasureUnit { get; set; }

        public decimal UnitQuantity { get; set; }

    }
}
