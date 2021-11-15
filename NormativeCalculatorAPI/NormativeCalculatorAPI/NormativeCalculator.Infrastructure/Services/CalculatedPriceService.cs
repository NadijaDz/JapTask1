using AutoMapper;
using NormativeCalculator.Database;
using NormativeCalculator.DTOs;
using NormativeCalculator.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public interface ICalculatedPriceService
    {
        decimal CalculatedPriceAsync(Recipes request );
        decimal CalculatedIngredientPrice(Recipes_Ingredients request);
    }
    public class CalculatedPriceService: ICalculatedPriceService
    {

        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;
   
        public CalculatedPriceService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public  decimal CalculatedPriceAsync(Recipes request)
        {
         
            var ingredientInRecipe = _context.Recipes_Ingredients.Where(x => x.Recipe_Id == request.Id).ToList();
            decimal totalCost = 0;
            decimal pricePerIngredient = 0;

            foreach (var item in ingredientInRecipe)
            {
                 pricePerIngredient = CalculatedIngredientPrice(item);
                 totalCost += pricePerIngredient;
            }
            //{
            //    var ingredient = _context.Ingredients.Where(x=>x.Id == item.Ingredient_Id).FirstOrDefault();

            //        if (ingredient.Id == item.Ingredient_Id)
            //        {
            //            var measureUnitFromIngredient = _context.MeasureUnits.Find(ingredient.MeasureUnit_Id);
            //            var measureUnitEntered= _context.MeasureUnits.Find(item.MeasureUnit_Id);

            //            if (item.MeasureUnit_Id== ingredient.MeasureUnit_Id)
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * item.UnitQuantity;
            //            }
            //            else if(ingredient.MeasureUnit.MeasureUnit == "kg" && measureUnitEntered.MeasureUnit == "gr")
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * (item.UnitQuantity/1000);

            //            }
            //            else if (ingredient.MeasureUnit.MeasureUnit == "gr" && measureUnitEntered.MeasureUnit == "kg")
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * (item.UnitQuantity * 1000);

            //            }
            //            else if (ingredient.MeasureUnit.MeasureUnit == "L" && measureUnitEntered.MeasureUnit == "ml")
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * (item.UnitQuantity / 1000);

            //            }
            //            else if (ingredient.MeasureUnit.MeasureUnit == "ml" && measureUnitEntered.MeasureUnit == "L")
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * (item.UnitQuantity * 1000);

            //            }
            //            else if (ingredient.MeasureUnit.MeasureUnit == "kom")
            //            {
            //                pricePerIngredient = ingredient.UnitPrice * item.UnitQuantity;

            //            }

                        //totalCost += pricePerIngredient;
                   // }
            //}

            return Math.Round(totalCost,2);
       
        }

        public decimal CalculatedIngredientPrice(Recipes_Ingredients request)
        {

            decimal pricePerIngredient = 0;

                var ingredient = _context.Ingredients.Where(x => x.Id == request.Ingredient_Id).FirstOrDefault();

                if (ingredient.Id == request.Ingredient_Id)
                {
                    var measureUnitFromIngredient = _context.MeasureUnits.Find(ingredient.MeasureUnit_Id);
                    var measureUnitEntered = _context.MeasureUnits.Find(request.MeasureUnit_Id);

                    if (request.MeasureUnit_Id == ingredient.MeasureUnit_Id)
                    {
                        pricePerIngredient = ingredient.UnitPrice * request.UnitQuantity;
                    }
                    else if (ingredient.MeasureUnit.MeasureUnit == "kg" && measureUnitEntered.MeasureUnit == "gr")
                    {
                        pricePerIngredient = ingredient.UnitPrice * (request.UnitQuantity / 1000);

                    }
                    else if (ingredient.MeasureUnit.MeasureUnit == "gr" && measureUnitEntered.MeasureUnit == "kg")
                    {
                        pricePerIngredient = ingredient.UnitPrice * (request.UnitQuantity * 1000);

                    }
                    else if (ingredient.MeasureUnit.MeasureUnit == "L" && measureUnitEntered.MeasureUnit == "ml")
                    {
                        pricePerIngredient = ingredient.UnitPrice * (request.UnitQuantity / 1000);

                    }
                    else if (ingredient.MeasureUnit.MeasureUnit == "ml" && measureUnitEntered.MeasureUnit == "L")
                    {
                        pricePerIngredient = ingredient.UnitPrice * (request.UnitQuantity * 1000);

                    }
                    else if (ingredient.MeasureUnit.MeasureUnit == "kom")
                    {
                        pricePerIngredient = ingredient.UnitPrice * request.UnitQuantity;

                    }
                }
            

                return Math.Round(pricePerIngredient, 2); 
        }
    }
}
