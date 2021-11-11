using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public class RecipeCategories
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public DateTime Created { get; set; }

    }
}
