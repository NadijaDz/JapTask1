using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Response
{
    public class GetRecipesIngredientsResponse
    {

        public int Recipe_Id { get; set; }

        public int Ingredient_Id { get; set; }

        public decimal UnitQuantity { get; set; }

        public string IngredinentName { get; set; }

        public string MeasureUnitName { get; set; }

        public decimal CostOfIngredient { get; set; }

    }
}
