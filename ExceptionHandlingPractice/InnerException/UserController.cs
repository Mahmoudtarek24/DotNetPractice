using ExceptionHandlingPractice.InnerException.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerException
{
	public class UserController
	{
		private UserService _userService = new UserService();

 
		public ApiResponse RegisterUser(string name, string email)
		{
			try
			{
				_userService.CreateUser(name, email);
				return new ApiResponse { Success = true, Message = "User Created Successfully" };
			}
			catch(Exception ex)
			{
				return new ApiResponse
				{
					Success = false,
					Message = "	Error occure",
					ErrorDetails = GetErrorChain(ex)
				};
			}
		}
		private List<string> GetErrorChain(Exception ex)
		{
			var errors = new List<string>();
			Exception currentEx = ex;
			while(currentEx is not null)
			{
				errors.Add($"{currentEx.GetType().Name}: {currentEx.Message}");
				currentEx = currentEx.InnerException;
			}
			return errors;
		}

	}
}
