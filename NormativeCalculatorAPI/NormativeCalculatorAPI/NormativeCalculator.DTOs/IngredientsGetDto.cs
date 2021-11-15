using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
    public class IngredientsGetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        public int MeasureUnit_Id { get; set; }

        //public IEnumerable<Recipes_Ingredients> Recipes_Ingredients { get; set; }
    }
}
