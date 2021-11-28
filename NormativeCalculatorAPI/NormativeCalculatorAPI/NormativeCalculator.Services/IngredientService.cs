using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Core.Models.Response;
using NormativeCalculator.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NormativeCalculator.Database;

namespace NormativeCalculator.Services
{
    public interface IIngredientService
    {
       Task<List<GetIngredientsResponse>> GetIngredientsAsync(CancellationToken cancellationToken);
       Task<GetIngredientsResponse> InsertIngredientAsync(AddIngredientRequest request, CancellationToken cancellationToken);
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

        public async Task<List<GetIngredientsResponse>> GetIngredientsAsync(CancellationToken cancellationToken)
        {
            var list = await _context.Ingredients.ToListAsync(cancellationToken);
            return _mapper.Map<List<GetIngredientsResponse>>(list);
        }

        public async Task<GetIngredientsResponse> InsertIngredientAsync(AddIngredientRequest request, CancellationToken cancellationToken)
        {

            var entity = _mapper.Map<Ingredient>(request);
            entity.CreatedAt = DateTime.Now;
            entity.IsDeleted = false;
            _context.Ingredients.Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetIngredientsResponse>(entity);
        }
    }
}
