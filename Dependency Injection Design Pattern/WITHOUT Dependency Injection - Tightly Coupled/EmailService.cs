using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.WITHOUT_Dependency_Injection___Tightly_Coupled
{
	public class EmailService
	{
		public void SendEmail(string to, string subject, string body)
		{
			Console.WriteLine($"Email sent to {to}: {subject}");
			// email sending logic here
		}
	}
}
