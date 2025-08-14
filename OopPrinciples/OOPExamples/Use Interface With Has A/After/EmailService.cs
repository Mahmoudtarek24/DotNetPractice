using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExanples.Use_Interface_With_Has_A.After
{
	public class EmailService : INotificationService
	{
		public void SendEmail(string to, string message)
		{
			Console.WriteLine($"Email sent to {to}: {message}");
		}
	}
}
