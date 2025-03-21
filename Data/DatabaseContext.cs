using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }        

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                    new Country { Id = 1, Name = "India", ShortName = "IND" },
                    new Country { Id = 2, Name = "New Zealand", ShortName = "NZ" },
                    new Country { Id = 3, Name = "Australia", ShortName = "AUS" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel { Id = 1, Name = "Wilderness Resort", Address = "Bangalore", Rating = 5, CountryId = 1 },
                    new Hotel { Id = 2, Name = "Palm Beach Resort And Spa", Address = "NZ", Rating = 4, CountryId = 2 },
                    new Hotel { Id = 3, Name = "Ravishing Retreat Resort", Address = "AUS", Rating = 4.5, CountryId = 3 }
                );
        }

    }
}
