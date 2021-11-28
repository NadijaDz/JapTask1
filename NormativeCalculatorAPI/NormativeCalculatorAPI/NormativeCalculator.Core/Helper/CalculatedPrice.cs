using NormativeCalculator.Common.Enums;
using NormativeCalculator.Core.Models.DTOs;
using System;
using System.Linq;

namespace NormativeCalculator.Core.Helper
{
    public static class CalculatedPrice
    {
        public static decimal CalculatedQuantityOnMinUnit(decimal quantity, MeasureUnit measureUnit)
        {
            if (measureUnit == MeasureUnit.kg || measureUnit == MeasureUnit.L)
            {
                return quantity * 1000;
            }
            else
            {
                return quantity;
            }
        }

        public static decimal CalculatedTotalPrice(Recipe request)
        {

            decimal totalCost = 0;

            var costPerIngredient = request.RecipesIngredients
                .Select(r => new CalculatedDto
                {
                    CostPerIngredient = (r.Ingredient.CostIngredient / 1000) * (CalculatedQuantityOnMinUnit(r.UnitQuantity, r.MeasureUnit))
                });

            totalCost = costPerIngredient.Sum(x => x.CostPerIngredient / 1000);

            return Math.Round(totalCost, 2);

        }

        public static decimal CalculatedIngredientPrice(decimal quantity, MeasureUnit unit, decimal ingredientCost)
        {
            return Math.Round((ingredientCost / 1000) * ((CalculatedQuantityOnMinUnit(quantity, unit))/1000), 2);
        }
    }
}
