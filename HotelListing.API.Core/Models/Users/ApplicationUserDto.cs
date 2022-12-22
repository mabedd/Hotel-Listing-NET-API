using System;
namespace HotetListing.API.Models.Users
{
	public class ApplicationUserDto : LoginDto
	{
		public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

