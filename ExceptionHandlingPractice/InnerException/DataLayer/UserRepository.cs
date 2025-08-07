using ExceptionHandlingPractice.InnerException.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerException.DataLayer
{
	public class UserRepository
	{
		public void SaveUser(User user)
		{
			try
			{
				if (user.Email.Contains("@"))
					throw new TimeoutException("Database connection timeout");
			}
			catch(TimeoutException ex) 
			{
				throw new DatabaseConnectionException("Failed to connect to database",ex);
			}
		}
	}
}
