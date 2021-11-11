using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NormativeCalculator.Infrastructure.Mapping;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI
{
    public static class InfrastructureServices
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {


            services.AddScoped<IRecipeCategoriesService, RecipeCategoriesService>();

            services.AddAutoMapper(typeof(NormativeCalculatorProfile).Assembly);


            return services;
        }
    }
}
