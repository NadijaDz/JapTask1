using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public class Recipes_Ingredients
    {

        [ForeignKey("Recipe_Id")]
        public Recipes Recipe { get; set; }
        public int Recipe_Id { get; set; }

        [ForeignKey("Ingredient_Id")]
        public Ingredients Ingredient { get; set; }
        public int Ingredient_Id { get; set; }


        [ForeignKey("MeasureUnit_Id")]
        public MeasureUnits MeasureUnit { get; set; }
        public int MeasureUnit_Id { get; set; }

        public decimal UnitQuantity { get; set; }


    }
}
