using NormativeCalculator.Common.Enums;
using NormativeCalculator.Core.Entities;
using System.Collections.Generic;

namespace NormativeCalculator.Core
{
    public class Ingredient : BaseEntity
    {

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        public MeasureUnit MeasureUnit { get; set; }

        public decimal CostIngredient { get; set; }

        public IEnumerable<RecipeIngredient> RecipesIngredients { get; set; }

    }
}
