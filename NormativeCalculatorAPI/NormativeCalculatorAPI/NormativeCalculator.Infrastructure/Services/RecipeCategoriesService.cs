using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.DTOs;
using NormativeCalculator.Infrastructure.EF;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{

    public interface IRecipeCategoriesService
    {
        Task<PaginationModel<List<RecipeCategoriesGetDto>>> GetRecipeCategoriesAsync(int skip, CancellationToken cancellationToken);
    }

    public class RecipeCategoriesService: IRecipeCategoriesService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public RecipeCategoriesService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PaginationModel<List<RecipeCategoriesGetDto>>> GetRecipeCategoriesAsync(int skip, CancellationToken cancellationToken)
        {
            var list = await _context.RecipeCategories
                .OrderByDescending(x=>x.Created)
                .Skip(skip)
                .Take(10).ToListAsync(cancellationToken);

            var countAllRecipeCategories = _context.RecipeCategories.Count();

            var data = _mapper.Map<List<RecipeCategoriesGetDto>>(list);

            return new PaginationModel<List<RecipeCategoriesGetDto>>(data, countAllRecipeCategories);
        }
    }
}
