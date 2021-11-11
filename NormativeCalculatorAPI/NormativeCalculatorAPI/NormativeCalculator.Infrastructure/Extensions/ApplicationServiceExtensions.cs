using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NormativeCalculator.Infrastructure.Services;
using NormativeCalculator.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Infrastructure.Mapping;

namespace NormativeCalculator.Infrastructure.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {


            services.AddScoped<IRecipeCategoriesService, RecipeCategoriesService>();

            services.AddAutoMapper(typeof(NormativeCalculatorProfile).Assembly);


            return services;
        }
    }
}
