using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core;
using NormativeCalculator.Common.Enums;
using System;
using System.Collections.Generic;

namespace NormativeCalculator.Database
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<RecipeCategory> recipeCategories = new List<RecipeCategory>()
            {
                new RecipeCategory{ Id=1, CategoryName="Breakfast", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=2, CategoryName="Lunch", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=3, CategoryName="Dinner", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=4, CategoryName="Snacks", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=5, CategoryName="Salads", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=6, CategoryName="Rice", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=7, CategoryName="Pasta", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=8, CategoryName="Chicken", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=9, CategoryName="Vegetarian", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=10, CategoryName="Meat", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=11, CategoryName="Seafood", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=12, CategoryName="Desserts", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=13, CategoryName="Drinks", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
                new RecipeCategory{ Id=14, CategoryName="Burgers", CreatedAt=new DateTime(new Random().Next(2021, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0) },
            };
            modelBuilder.Entity<RecipeCategory>().HasData(recipeCategories);

            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient{ Id=1, Name="Oil",CostIngredient=2,UnitQuantity=1, MeasureUnit=MeasureUnit.L, UnitPrice=2/1000},
                new Ingredient{ Id=2, Name="Water",CostIngredient=1,UnitQuantity=1,MeasureUnit=MeasureUnit.L, UnitPrice=1/1000},
                new Ingredient{ Id=3, Name="Sugar",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=4, Name="Flour",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=5, Name="Chocolate",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.gr, UnitPrice=8},
                new Ingredient{ Id=6, Name="Rice",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=7, Name="Spaghetti",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.gr,UnitPrice=2*4},
                new Ingredient{ Id=8, Name="Chicken",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=9, Name="Avocado",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=10, Name="Salt",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=11, Name="Banana",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=12, Name="Apple",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, UnitPrice=2/4000},
                new Ingredient{ Id=13, Name="Mayonnaise",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.ml, UnitPrice=8},
                new Ingredient{ Id=14, Name="Bread",CostIngredient=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kom, UnitPrice=8},
            };
            modelBuilder.Entity<Ingredient>().HasData(ingredients);
        }
    }
}
