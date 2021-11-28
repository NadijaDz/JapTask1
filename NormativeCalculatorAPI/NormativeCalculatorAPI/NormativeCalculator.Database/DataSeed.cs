﻿using Microsoft.EntityFrameworkCore;
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
                new Ingredient{ Id=1, Name="Oil",UnitPrice=2,UnitQuantity=1, MeasureUnit=MeasureUnit.L, CostIngredient=2*(1*1000)},
                new Ingredient{ Id=2, Name="Water",UnitPrice=1,UnitQuantity=1,MeasureUnit=MeasureUnit.L, CostIngredient=1*(1*1000)},
                new Ingredient{ Id=3, Name="Sugar",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=4, Name="Flour",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=5, Name="Chocolate",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.gr, CostIngredient=2*4},
                new Ingredient{ Id=6, Name="Rice",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=7, Name="Spaghetti",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.gr,CostIngredient=2*4},
                new Ingredient{ Id=8, Name="Chicken",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=9, Name="Avocado",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=10, Name="Salt",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=11, Name="Banana",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=12, Name="Apple",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kg, CostIngredient=(2*1000)/4},
                new Ingredient{ Id=13, Name="Mayonnaise",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.ml, CostIngredient=2*4},
                new Ingredient{ Id=14, Name="Bread",UnitPrice=2,UnitQuantity=4,MeasureUnit=MeasureUnit.kom, CostIngredient=2*4},
            };
            modelBuilder.Entity<Ingredient>().HasData(ingredients);

            //List<MeasureUnits> measureUnits = new List<MeasureUnits>()
            //{
            //    new MeasureUnits{ Id=1, MeasureUnit="L"},
            //    new MeasureUnits{ Id=2, MeasureUnit="kg"},
            //    new MeasureUnits{ Id=3, MeasureUnit="gr"},
            //    new MeasureUnits{ Id=4, MeasureUnit="ml"},
            //    new MeasureUnits{ Id=5, MeasureUnit="kom"},
            //};
            //modelBuilder.Entity<MeasureUnits>().HasData(measureUnits);
        }
    }
}