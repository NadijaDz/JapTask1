using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
    public class IngredientAddRequest
    {

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        public int MeasureUnit_Id { get; set; }
    }
}
