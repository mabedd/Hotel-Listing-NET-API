using System;
using AutoMapper;
using HotetListing.API.Data;
using HotetListing.API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HotetListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRespository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}

