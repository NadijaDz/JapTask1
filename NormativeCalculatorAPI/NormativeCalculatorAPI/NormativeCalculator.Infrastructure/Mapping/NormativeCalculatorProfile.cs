using AutoMapper;
using NormativeCalculator.Database;
using NormativeCalculator.DTOs;

namespace NormativeCalculator.Infrastructure.Mapping
{
    public class NormativeCalculatorProfile : Profile
    {
        public NormativeCalculatorProfile()
        {

            CreateMap<RecipeCategories, RecipeCategoriesGetDto>();
            CreateMap<Recipes, RecipesGetDto>();
            CreateMap<Recipes, RecipesInsertGetDto>();
            CreateMap<Ingredients, IngredientsGetDto>();
            CreateMap<Ingredients, IngredientAddRequest>().ReverseMap();
            CreateMap<MeasureUnits, MeasureUnitGetDto>();
            CreateMap<Recipes, RecipesAddRequest>().ReverseMap();

        }
    }
}
