using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Response
{
    public class GetRecipeCategoriesResponse
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public DateTime Created { get; set; }
    }
}
