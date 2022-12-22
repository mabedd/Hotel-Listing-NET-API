﻿using System;
using Microsoft.AspNetCore.Identity;

namespace HotetListing.API.Data
{
	public class ApplicationUser : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}

