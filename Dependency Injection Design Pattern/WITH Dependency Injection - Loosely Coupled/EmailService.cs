using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.WITH_Dependency_Injection___Loosely_Coupled
{
	internal class EmailService : INotificationService
	{
		public void SendNotification(string to, string subject, string message)
		{
			Console.WriteLine($" Email sent to {to}: {subject}");
		}
	}
}
