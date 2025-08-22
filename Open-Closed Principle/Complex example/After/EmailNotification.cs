using Open_Closed_Principle.Complex_example.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.After
{
	public class EmailNotification : BaseNotification
	{
		public string Subject { get; set; }
		public string SenderEmail { get; set; }

		public override NotificationResult SendNotification()
		{
			if (!ValidateNotification())
				return base.FailedNotification();

			Console.WriteLine($"Sending Email to: {Recipient}");
			Console.WriteLine($"Subject: {Subject}");
			Console.WriteLine($"From: {SenderEmail}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "Email sent successfully",
				TrackingId = $"EMAIL_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}

		public override bool ValidateNotification() =>  !string.IsNullOrEmpty(Recipient) &&
	                      	 !string.IsNullOrEmpty(Subject) &&  Recipient.Contains("@");
	}
}
