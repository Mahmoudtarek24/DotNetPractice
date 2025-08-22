using Open_Closed_Principle.Complex_example.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.After
{
	public abstract class BaseNotification
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Recipient { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public abstract NotificationResult SendNotification();
		public abstract bool ValidateNotification();

		public virtual NotificationResult FailedNotification()
		{
			return new NotificationResult
			{
				IsSuccess = false,
				Message = "Validation failed",
				SentAt = DateTime.Now
			};
		}
	}
}
