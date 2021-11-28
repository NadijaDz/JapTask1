using NormativeCalculator.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Request
{
    public class AddIngredientRequest
    {

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        public MeasureUnit MeasureUnit { get; set; }

        public decimal CostIngredient { get; set; }

    }
}
