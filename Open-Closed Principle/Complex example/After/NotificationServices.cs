using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.After
{
	public class NotificationServices
	{
		public void PrintInfo(List<BaseNotification> baseNotifications)
		{
			foreach (var baseNotification in baseNotifications)
				Console.WriteLine(baseNotification.SendNotification());
		}
	}
}
