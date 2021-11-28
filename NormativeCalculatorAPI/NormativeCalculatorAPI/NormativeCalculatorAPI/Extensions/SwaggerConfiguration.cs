using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace NormativeCalculator.API.Extensions
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection RegisterSwaggerConfiguration(this IServiceCollection services, IConfiguration config)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NormativeCalculatorAPI", Version = "v1" });
            });

            return services;
        }
    }
}
