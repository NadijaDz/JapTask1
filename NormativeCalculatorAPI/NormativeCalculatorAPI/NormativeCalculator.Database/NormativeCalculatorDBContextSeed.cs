using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
    public static class NormativeCalculatorDBContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            
            List<RecipeCategories> recipeCategories = new List<RecipeCategories>()
            {
                new RecipeCategories{ Id=1, CategoryName="Breakfast", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=2, CategoryName="Lunch", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=3, CategoryName="Dinner", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=4, CategoryName="Snacks", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=5, CategoryName="Salads", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=6, CategoryName="Rice", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=7, CategoryName="Pasta", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=8, CategoryName="Chicken", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=9, CategoryName="Vegetarian", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=10, CategoryName="Meat", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=11, CategoryName="Seafood", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=12, CategoryName="Desserts", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=13, CategoryName="Drinks", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategories{ Id=14, CategoryName="Burgers", Created=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
            };
            modelBuilder.Entity<RecipeCategories>().HasData(recipeCategories);

            List<Ingredients> ingredients = new List<Ingredients>()
            {
                new Ingredients{ Id=1, Name="Oil",UnitPrice=2,UnitQuantity=1,MeasureUnit_Id=1},
                new Ingredients{ Id=2, Name="Water",UnitPrice=1,UnitQuantity=1,MeasureUnit_Id=1},
                new Ingredients{ Id=3, Name="Sugar",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=2},
                new Ingredients{ Id=4, Name="Flour",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=2},
                new Ingredients{ Id=5, Name="Chocolate",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=3},
                new Ingredients{ Id=6, Name="Rice",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=2},
                new Ingredients{ Id=7, Name="Spaghetti",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=3},
                new Ingredients{ Id=8, Name="Chicken",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=2},
                new Ingredients{ Id=9, Name="Avocado",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=2},
                new Ingredients{ Id=10, Name="Salt",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=3},
                new Ingredients{ Id=11, Name="Banana",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=5},
                new Ingredients{ Id=12, Name="Apple",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=5},
                new Ingredients{ Id=13, Name="Mayonnaise",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=4},
                new Ingredients{ Id=14, Name="Bread",UnitPrice=2,UnitQuantity=4,MeasureUnit_Id=5},
            };
            modelBuilder.Entity<Ingredients>().HasData(ingredients);

            List<MeasureUnits> measureUnits = new List<MeasureUnits>()
            {
                new MeasureUnits{ Id=1, MeasureUnit="L"},
                new MeasureUnits{ Id=2, MeasureUnit="kg"},
                new MeasureUnits{ Id=3, MeasureUnit="gr"},
                new MeasureUnits{ Id=4, MeasureUnit="ml"},
                new MeasureUnits{ Id=5, MeasureUnit="kom"},
            };
            modelBuilder.Entity<MeasureUnits>().HasData(measureUnits);

        }

        }
}
