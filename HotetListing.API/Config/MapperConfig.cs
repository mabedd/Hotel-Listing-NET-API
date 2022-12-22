using System;
using AutoMapper;
using HotetListing.API.Data;
using HotetListing.API.Models.Country;
using HotetListing.API.Models.Hotels;
using HotetListing.API.Models.Users;

namespace HotetListing.API.Config
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDetailsDto>().ReverseMap();
			CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

			CreateMap<ApplicationUserDto, ApplicationUser>().ReverseMap();
        }
	}
}



