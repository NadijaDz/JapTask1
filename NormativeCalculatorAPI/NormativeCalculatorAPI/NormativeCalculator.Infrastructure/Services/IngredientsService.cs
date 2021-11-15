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
    public interface IIngredientsService
    {
       Task<List<IngredientsGetDto>> GetIngredientsAsync(CancellationToken cancellationToken);
        Task<IngredientsGetDto> InsertIngredientAsync(IngredientAddRequest request, CancellationToken cancellationToken);
    }
    public class IngredientsService : IIngredientsService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public IngredientsService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<IngredientsGetDto>> GetIngredientsAsync(CancellationToken cancellationToken)
        {
            var list = await _context.Ingredients.ToListAsync(cancellationToken);
            return _mapper.Map<List<IngredientsGetDto>>(list);
        }

        public async Task<IngredientsGetDto> InsertIngredientAsync(IngredientAddRequest request, CancellationToken cancellationToken)
        {
         
            var entity = _mapper.Map<Database.Ingredients>(request);
            _context.Ingredients.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<IngredientsGetDto>(entity);
        }
    }
}
