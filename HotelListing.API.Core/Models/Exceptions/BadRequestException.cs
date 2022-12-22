using System;
namespace HotetListing.API.Exceptions
{
	public class BadRequestException : ApplicationException
	{
        public BadRequestException(string message) : base(message)
        {

        }
    }
}

