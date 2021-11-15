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
    public interface IMeasureUnitService
    {
        Task<List<MeasureUnitGetDto>> GetMeasureUnitAsync(CancellationToken cancellationToken);
    }
    public class MeasureUnitService : IMeasureUnitService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;

        public MeasureUnitService(NormativeCalculatorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<MeasureUnitGetDto>> GetMeasureUnitAsync(CancellationToken cancellationToken)
        {
            var list = await _context.MeasureUnits.ToListAsync(cancellationToken);
            return _mapper.Map<List<MeasureUnitGetDto>>(list);
        }
    }
}
