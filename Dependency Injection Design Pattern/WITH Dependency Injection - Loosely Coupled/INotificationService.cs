using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.WITH_Dependency_Injection___Loosely_Coupled
{
	public interface INotificationService
	{
		public void SendNotification(string to, string subject, string message);
	}
}
