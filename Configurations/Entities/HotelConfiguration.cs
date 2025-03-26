using HotelBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                    new Hotel { Id = 1, Name = "Wilderness Resort", Address = "Bangalore", Rating = 5, CountryId = 1 },
                    new Hotel { Id = 2, Name = "Palm Beach Resort And Spa", Address = "NZ", Rating = 4, CountryId = 2 },
                    new Hotel { Id = 3, Name = "Ravishing Retreat Resort", Address = "AUS", Rating = 4.5, CountryId = 3 }
                );
        }
    }
}
