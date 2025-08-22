using Open_Closed_Principle.Complex_example.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.After
{
	public class SMSNotification : BaseNotification
	{
		public string PhoneNumber { get; set; }
		public override NotificationResult SendNotification()
		{
			if (!ValidateNotification())
				return base.FailedNotification();

			Console.WriteLine($"Sending SMS to: {PhoneNumber}");
			Console.WriteLine($"Message: {Content}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "SMS sent successfully",
				TrackingId = $"SMS_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}
		public override bool ValidateNotification() => !string.IsNullOrEmpty(PhoneNumber) & PhoneNumber.Length >= 10;
	}
}
