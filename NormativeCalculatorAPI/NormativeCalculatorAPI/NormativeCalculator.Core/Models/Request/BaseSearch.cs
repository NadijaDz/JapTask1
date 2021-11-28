using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Request
{
    public class BaseSearch
    {
        public string SearchQuery { get; set; }
        public int Skip { get; set; }

    }
}
