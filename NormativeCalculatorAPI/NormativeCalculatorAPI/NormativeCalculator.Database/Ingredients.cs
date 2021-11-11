using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public class Ingredients
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        [ForeignKey("MeasureUnit_Id")]
        public MeasureUnits MeasureUnit { get; set; }
        public int MeasureUnit_Id { get; set; }

        public IEnumerable<Recipes> Recipes { get; set; }


    }
}
