using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.DTOs;
using NormativeCalculator.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public interface IRecipesService
    {
        Task<RecipesGetDto> GetRecipesByIdAsync(int id, CancellationToken cancellationToken);
        Task<PaginationModel<List<RecipesGetDto>>> GetRecipesAsync(IncomingParamsModel request, CancellationToken cancellationToken);
        Task<RecipesInsertGetDto> InsertRecipeAsync(RecipesAddRequest request, CancellationToken cancellationToken);
    }
    public class RecipesService : IRecipesService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICalculatedPriceService _calculatedPriceService;


        public RecipesService(NormativeCalculatorDBContext context, IMapper mapper, UserManager<IdentityUser> userManager,
            ICalculatedPriceService calculatedPriceService)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _calculatedPriceService = calculatedPriceService;
        }

        public async Task<RecipesGetDto> GetRecipesByIdAsync(int id, CancellationToken cancellationToken)
        {
            var recipe = await _context.Recipes.Include(i => i.Recipes_Ingredients)
                .Select(s => new RecipesGetDto
                {
                    Id=s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    TotalCost = _calculatedPriceService.CalculatedPriceAsync(s),
                    Recipes_Ingredients=s.Recipes_Ingredients.Select(c=>
                        new Recipe_IngredientsGetDto
                        {
                            Ingredient_Id=c.Ingredient_Id,
                            Recipe_Id=c.Recipe_Id,
                            MeasureUnit_Id=c.MeasureUnit_Id,
                            UnitQuantity=c.UnitQuantity,
                            IngredinentName=c.Ingredient.Name,
                            MeasureUnitName=c.MeasureUnit.MeasureUnit,
                            CostOfIngredient = _calculatedPriceService.CalculatedIngredientPrice(c)

                        }
                        ).ToList()
                })
                .Where(x => x.Id == id).FirstOrDefaultAsync();

            return recipe;
        }

        public async Task<PaginationModel<List<RecipesGetDto>>> GetRecipesAsync(IncomingParamsModel request, CancellationToken cancellationToken)
        {

           

            var list = await _context.Recipes
               .Where(x => x.RecipeCategory_Id == request.categoryId)
               .Where(s => (string.IsNullOrWhiteSpace(request.SearchQuery)) ||
                   s.Name.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                   s.Description.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                   s.Recipes_Ingredients.Any(y => y.Ingredient.Name.ToLower().Contains(request.SearchQuery)))
               .Select(s => new RecipesGetDto
               {
                   Id=s.Id,
                   Name = s.Name,
                   Description = s.Description,
                   TotalCost = _calculatedPriceService.CalculatedPriceAsync(s)
               }).ToListAsync(cancellationToken);

            list = list.OrderBy(x => x.TotalCost).ThenByDescending(c=> c.Created).Skip(request.Skip)
               .Take(10)
               .ToList();

          
            var countAllRecipes = _context.Recipes.Count();
            var data = _mapper.Map<List<RecipesGetDto>>(list);

           return new PaginationModel<List<RecipesGetDto>>(data, countAllRecipes);
        }

        public async Task<RecipesInsertGetDto> InsertRecipeAsync(RecipesAddRequest request, CancellationToken cancellationToken)
        {
           
    
            var entity = _mapper.Map<Database.Recipes>(request);
            entity.User.Id = request.UserId;
            entity.Created = DateTime.Now;
        
            _context.Recipes.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            if (request.Ingredients != null)
            {
                foreach (var ingredient in request.Ingredients)
                {
                    _context.Recipes_Ingredients.Add(
                        new Recipes_Ingredients() { 
                            Recipe_Id = entity.Id, 
                            Ingredient_Id = ingredient.Ingredient_Id, 
                            MeasureUnit_Id= ingredient.MeasureUnit_Id,
                            UnitQuantity= ingredient.UnitQuantity
                            
                        }
                    );
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<RecipesInsertGetDto>(entity);
        }

    }
}
