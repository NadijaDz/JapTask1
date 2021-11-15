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
            services.AddScoped<IRecipesService, RecipesService>();
            services.AddScoped<IIngredientsService, IngredientsService>();
            services.AddScoped<IMeasureUnitService, MeasureUnitService>();
            services.AddScoped<ICalculatedPriceService, CalculatedPriceService>();





            services.AddAutoMapper(typeof(NormativeCalculatorProfile).Assembly);


            return services;
        }
    }
}
