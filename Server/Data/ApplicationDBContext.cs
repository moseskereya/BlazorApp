using BlazorApp4.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>().HasData(
                new Developer
                {
                    Id = 1,
                    FirstName = "Moses",
                    LastName = "Lazaro",
                    Email = "myemail@gmail.com",
                    Experience = 3
                },
                 new Developer
                 {
                     Id = 2,
                     FirstName = "Scott",
                     LastName = "Cate",
                     Email = "scott@gmail.com",
                     Experience = 40
                 },
                 new Developer
                 {
                     Id = 3,
                     FirstName = "Dev",
                     LastName = "Edd",
                     Email = "Dev@gmai.com",
                     Experience = 10,
                 },
                  new Developer
                  {
                      Id = 4,
                      FirstName = "Brad",
                      LastName = "Travesy",
                      Email = "travesy@gmail.com",
                      Experience = 20
                  }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
