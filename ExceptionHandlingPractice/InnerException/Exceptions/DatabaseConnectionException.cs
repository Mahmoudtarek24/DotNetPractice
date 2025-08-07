using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerException.Exceptions
{
	public class DatabaseConnectionException : Exception
	{
		public DatabaseConnectionException() { }
		public DatabaseConnectionException(string message ,Exception innerException) :base(message ,innerException) { }
	}
}
