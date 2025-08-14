using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExanples.Use_Interface_With_Has_A.Before
{
	public class NotificationManager
	{
		private EmailService emailService;
		public NotificationManager()
		{
				emailService = new EmailService(); // hard code dependency 
		}
		public void SendNotification(string to, string message)    
		{
			emailService.SendEmail(to, message); 
		}
	}
}
/// the problem her i only used the email way can not used any type else 
