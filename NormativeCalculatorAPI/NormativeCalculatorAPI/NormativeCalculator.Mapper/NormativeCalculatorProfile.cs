using AutoMapper;
using NormativeCalculator.Core;
using NormativeCalculator.Core.Models.DTOs;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Core.Models.Response;

namespace NormativeCalculator.Mapper.Mapping
{
    public class NormativeCalculatorProfile : Profile
    {
        public NormativeCalculatorProfile()
        {

            CreateMap<RecipeCategory, GetRecipeCategoriesResponse>();
            CreateMap<Recipe, GetRecipesResponse>();
            CreateMap<GetRecipesDto, GetRecipesResponse>();
            CreateMap<RecipeIngredient, GetRecipesIngredientsDto>();
            CreateMap<Ingredient, GetIngredientsResponse>();
            CreateMap<Ingredient, AddIngredientRequest>().ReverseMap();
            CreateMap<Recipe, AddRecipeRequest>().ReverseMap();

        }
    }
}
