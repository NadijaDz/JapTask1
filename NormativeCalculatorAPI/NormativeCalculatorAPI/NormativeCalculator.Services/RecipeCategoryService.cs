using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.Models.Response;
using NormativeCalculator.Database;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Services
{

    public interface IRecipeCategoryService
    {
        Task<PaginationResponse<List<GetRecipeCategoriesResponse>>> GetRecipeCategoriesAsync(int skip, CancellationToken cancellationToken);
    }

    public class RecipeCategoryService : IRecipeCategoryService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public RecipeCategoryService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<List<GetRecipeCategoriesResponse>>> GetRecipeCategoriesAsync(int skip, CancellationToken cancellationToken)
        {
            var list = await _context.RecipeCategories
                .OrderByDescending(x => x.CreatedAt)
                .Skip(skip)
                .Take(10).ToListAsync(cancellationToken);

            var countAllRecipeCategories = _context.RecipeCategories.Count();

            var data = _mapper.Map<List<GetRecipeCategoriesResponse>>(list);

            return new PaginationResponse<List<GetRecipeCategoriesResponse>>(data, countAllRecipeCategories);
        }
    }
}
