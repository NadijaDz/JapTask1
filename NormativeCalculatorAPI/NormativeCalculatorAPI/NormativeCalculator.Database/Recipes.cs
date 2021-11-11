using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public class Recipes
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime Created { get; set; }

        [ForeignKey("RecipeCategory_Id")]
        public RecipeCategories RecipeCategory { get; set; }
        public int RecipeCategory_Id { get; set; }

        [ForeignKey("User_Id")]
        public Users User { get; set; }
        public int User_Id { get; set; }

        public IEnumerable<Ingredients> Ingredients { get; set; }


    }
}
