using System;
using AutoMapper;
using HotetListing.API.Data;
using HotetListing.API.Repository.IRepository;

namespace HotetListing.API.Repository
{
	public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
		public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
		{
		}
	}
}

