using System;
using HotetListing.API.Models.Hotels;

namespace HotetListing.API.Models.Country
{
	public class CountryDetailsDto : CountryDto
	{
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}

