using System;
using HotetListing.API.Data;

namespace HotetListing.API.Repository.IRepository
{
    public interface ICountriesRespository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}

