using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerExceptionExample2.Exceptions
{
	public class UserNotFoundException : Exception
	{
		public UserNotFoundException(string message, Exception innerException) : base(message, innerException) { }
	}
}
