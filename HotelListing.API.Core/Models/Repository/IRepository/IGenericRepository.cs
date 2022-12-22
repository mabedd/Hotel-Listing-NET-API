using System;
using HotetListing.API.Data;
using HotetListing.API.Models;

namespace HotetListing.API.Repository.IRepository
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetAsync(int? id);
		Task<List<T>> GetAllAsync();
		Task<PagedResult<TResult>> GetAllSync<TResult>(QueryParameters queryParameters);
		Task<T> AddAsync(T entity);
		Task DeleteAsync(int id);
		Task UpdateAsync(T entity);
		Task<bool> Exists(int id);
	}
}

