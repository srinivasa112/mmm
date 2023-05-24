using Microsoft.EntityFrameworkCore;
using CitiesManager.WebAPI.Models;

namespace CitiesManager.WebAPI.DaabaseContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public ApplicationDbContext() 
        { 
        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() { CityID =
            Guid.Parse("88F3EBEF-0A30-452E-9B60-C1C272AF43F2"), CityName = "NewYork" 
            });

            modelBuilder.Entity<City>().HasData(new City() { CityID =
            Guid.Parse("8D51C6DF-326D-4736-8B78-E69F6C98C9A5"),CityName = "London"
            });
             
        }
        }
    }

