using ExceptionHandlingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
	public class OddNumberException : Exception
	{
		public override string Message => "Divisor Cannot be Odd Number" ;
	}
}
/// parent class exception have empty constructor to when child class like "OddNumberException" dint create constructor
/// compiler create default constructor and calling parent class constructor 
///  puplic OddNumberException() :base () {}
///  public class OddNumberException : Exception
///  {
///		public OddNumberException() { }
///     public OddNumberException(string message)  :base(message) { }
///	}
///	
///
///	throw new OddNumberException("will put my message her");
