using NormativeCalculator.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.DTOs
{
    public class GetRecipesIngredientsDto
    {
        public int Recipe_Id { get; set; }

        public int Ingredient_Id { get; set; }

        public decimal UnitQuantity { get; set; }

        public string IngredinentName { get; set; }

        public MeasureUnit MeasureUnits { get; set; }

        public decimal CostOfIngredient { get; set; }

    }
}
