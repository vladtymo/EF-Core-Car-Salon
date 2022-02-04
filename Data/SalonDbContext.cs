using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Salon
{
    public class SalonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=SalonDb2022;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasOne(c => c.Category).WithMany(c => c.Cars);
            modelBuilder.Entity<Car>().HasOne(c => c.Country).WithMany(c => c.Cars);

            var categories = new List<Category>()
            {
                new Category() { Id=1, Name = "Sedan" },
                new Category() { Id=2, Name = "Coupe" },
                new Category() { Id=3, Name = "Sport Car" },
                new Category() { Id=4, Name = "Hatchback" },
                new Category() { Id=5, Name = "Minivan" },
                new Category() { Id=6, Name = "SUV" }
            };

            modelBuilder.Entity<Category>().HasData(categories);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
