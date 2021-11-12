using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs
{
    public class IncomingParamsModel
    {
        public int categoryId { get; set; }
        public int Skip { get; set; }
        public string SearchQuery { get; set; }
    }
}
