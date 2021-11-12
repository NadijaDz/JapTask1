using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public interface IRecipesService
    {
        Task<PaginationModel<List<RecipesGetDto>>> GetRecipesAsync(IncomingParamsModel request, CancellationToken cancellationToken);
    }
    public class RecipesService : IRecipesService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public RecipesService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginationModel<List<RecipesGetDto>>> GetRecipesAsync(IncomingParamsModel request, CancellationToken cancellationToken)
        {
           
            var list = await _context.Recipes
                .Where(x => x.RecipeCategory_Id == request.categoryId)
                .OrderByDescending(x => x.Created)
                .Where(s => (string.IsNullOrWhiteSpace(request.SearchQuery)) ||
                    s.Name.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                    s.Description.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                    s.Recipes_Ingredients.Any(y => y.Ingredient.Name.ToLower().Contains(request.SearchQuery)))
                .Skip(request.Skip)
                .Take(10)
                .ToListAsync(cancellationToken);

            var countAllRecipes = _context.Recipes.Count();
            var data = _mapper.Map<List<RecipesGetDto>>(list);

           return new PaginationModel<List<RecipesGetDto>>(data, countAllRecipes);
        }
    }
}
