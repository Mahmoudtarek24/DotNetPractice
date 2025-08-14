using OopPrinciples.OOPExanples.Use_Interface_With_Has_A.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExanples.Use_Interface_With_Has_A.After
{
	public class Sms
	{
		private INotificationService notificationService;

		public Sms(INotificationService notificationService)
		{
			this.notificationService = notificationService;
		}
		public void SendNotification(string to, string message)
		{
			notificationService.SendEmail(to, message);
		}
	}
}
