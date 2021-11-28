using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.EF;
using NormativeCalculator.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public interface IIngredientService
    {
       Task<List<IngredientsGetDto>> GetIngredientsAsync(CancellationToken cancellationToken);
       //Task<IngredientsGetDto> InsertIngredientAsync(AddIngredientRequest request, CancellationToken cancellationToken);
    }

    public class IngredientService : IIngredientService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public IngredientService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<IngredientsGetDto>> GetIngredientsAsync(CancellationToken cancellationToken)
        {
            var list = await _context.Ingredients.ToListAsync(cancellationToken);
            return _mapper.Map<List<IngredientsGetDto>>(list);
        }

        //public async Task<IngredientsGetDto> InsertIngredientAsync(AddIngredientRequest request, CancellationToken cancellationToken)
        //{
         
        //    var entity = _mapper.Map<Database.Ingredient>(request);
        //    _context.Ingredients.Add(entity);
        //    await _context.SaveChangesAsync();

        //    return _mapper.Map<IngredientsGetDto>(entity);
        //}
    }
}
