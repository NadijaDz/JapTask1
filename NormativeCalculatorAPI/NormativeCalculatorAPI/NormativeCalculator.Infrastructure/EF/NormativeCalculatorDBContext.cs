using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.EF
{
    public class NormativeCalculatorDBContext : IdentityDbContext
    {
        public NormativeCalculatorDBContext(DbContextOptions<NormativeCalculatorDBContext> options) : base(options)
        {
        }

        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<RecipeCategories> RecipeCategories { get; set; }
        public DbSet<MeasureUnits> MeasureUnits { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes_Ingredients> Recipes_Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.Entity<Recipes_Ingredients>().HasKey(sc => new { sc.Ingredient_Id, sc.Recipe_Id });
        }



    }
}
