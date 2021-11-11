using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public class MeasureUnits
    {
        [Key]
        public int Id { get; set; }

        public string MeasureUnit { get; set; }

    }
}
