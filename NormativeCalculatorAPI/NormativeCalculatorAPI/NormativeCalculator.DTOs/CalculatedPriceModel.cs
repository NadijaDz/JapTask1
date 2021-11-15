using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
   public class CalculatedPriceModel
    {
        public decimal PriceOfIngredient { get; set; }
        public decimal UnitQuantity { get; set; }
        public int MeasureUnit_Id { get; set; }

    }
}
