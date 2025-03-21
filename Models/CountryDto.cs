using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }

        public virtual IList<HotelDto> Hotels { get; set; }
    }

    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 5, ErrorMessage = "Country short name is too long")]
        public string ShortName { get; set; }
    }
}
