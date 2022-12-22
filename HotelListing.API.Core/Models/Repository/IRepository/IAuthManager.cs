using System;
using HotetListing.API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotetListing.API.Repository.IRepository
{
	public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApplicationUserDto userDto);
		Task<LoginResponseDto> Login(LoginDto loginDto);
		Task<string> CreateRefreshToken();
		Task<LoginResponseDto> VerifyRefreshToken(LoginResponseDto request);
	}
}

