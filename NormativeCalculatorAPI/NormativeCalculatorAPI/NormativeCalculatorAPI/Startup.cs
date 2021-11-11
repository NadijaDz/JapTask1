
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NormativeCalculator.Infrastructure.EF;
using NormativeCalculator.Infrastructure.Extensions;
using System;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NormativeCalculatorAPI", Version = "v1" });
            });

            services.AddDbContext<NormativeCalculatorDBContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.RegisterInfrastructureServices(Configuration);

           
            services.AddIdentity< IdentityUser, IdentityRole >()
             .AddEntityFrameworkStores<NormativeCalculatorDBContext>()
             .AddDefaultTokenProviders();


            services.AddAuthentication().AddCookie()
                    .AddGoogle(options =>
            {
              IConfigurationSection googleAuthNSection =
                  Configuration.GetSection("Authentication:Google");

              options.ClientId = googleAuthNSection["ClientId"];
              options.ClientSecret = googleAuthNSection["ClientSecret"];
            });
            //services.ConfigureApplicationCookie(options =>
            //  {
            //      // Cookie settings
            //      options.Cookie.HttpOnly = false;
            //      options.ExpireTimeSpan = TimeSpan.FromMinutes(10);

            //  });

            // ===== Configure Identity =======
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "auth_cookie";
                options.Cookie.SameSite = SameSiteMode.None;
                options.LoginPath = new PathString("/api/Login/signin-google");
                options.AccessDeniedPath = new PathString("/api/contests");
                options.Cookie.HttpOnly = false;

                options.Events.OnRedirectToLogin = context =>
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    return Task.CompletedTask;
                };
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NormativeCalculatorAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
              .AllowAnyMethod()
              .AllowAnyHeader()
              .SetIsOriginAllowed(origin => true) // allow any origin
              .AllowCredentials()); // allow credentials

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
