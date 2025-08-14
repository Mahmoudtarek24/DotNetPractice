using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExanples.Use_Interface_With_Has_A.Before
{
	public class EmailService
	{
		public void SendEmail(string to, string message)
		{
			Console.WriteLine($"Sending email to {to}: {message}");
		}
	}
}
