using ExceptionHandlingPractice.InnerException.DataLayer;
using ExceptionHandlingPractice.InnerException.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerException.Business_Layer
{
	public class UserService
	{
		private UserRepository _repository = new UserRepository();

		public void CreateUser(string name, string email)
		{
			try
			{
				ValidateUserData(name, email);
				var user = new User { Name = name, Email = email };
				_repository.SaveUser(user);
			}
			catch(Exception ex)
			{
				throw new BusinessLogicException($"Failed to create user :{name}", ex);
			}
		}
		private void ValidateUserData(string name, string email)
		{
			try
			{
				if (string.IsNullOrEmpty(name))
					throw new ArgumentException("name is required");

				if (string.IsNullOrEmpty(email) || !email.Contains("@"))
					throw new FormatException("Incorrect email format");
			}
			catch (Exception ex)
			{
				throw new System.ComponentModel.DataAnnotations.ValidationException("faild in verifying user data", ex); //ex=> will hold Exception from type
																				   //ArgumentException ,FormatException
			}
		}
	}
}
