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
        Task<List<RecipeCategoriesGetDto>> GetRecipeCategoriesAsync(int take, CancellationToken cancellationToken);
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
        public async Task<List<RecipeCategoriesGetDto>> GetRecipeCategoriesAsync(int take, CancellationToken cancellationToken)
        {
            var list = await _context.RecipeCategories.OrderByDescending(x=>x.Created).Take(take).ToListAsync(cancellationToken);
            return _mapper.Map<List<RecipeCategoriesGetDto>>(list);
        }
    }
}
