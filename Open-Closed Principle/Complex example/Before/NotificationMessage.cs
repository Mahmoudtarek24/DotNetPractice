using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.Before
{
	public class NotificationMessage
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Recipient { get; set; }
		public NotificationType Type { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		// Email specific
		public string Subject { get; set; }
		public string SenderEmail { get; set; }
		// SMS specific  
		public string PhoneNumber { get; set; }
		// Push specific
		public string DeviceToken { get; set; }
		public string AppId { get; set; }
		// Slack specific
		public string Channel { get; set; }
		public string SlackToken { get; set; }
	}
}
