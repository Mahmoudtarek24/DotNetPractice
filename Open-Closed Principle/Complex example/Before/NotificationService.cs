using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.Before
{
	public class NotificationService
	{
		public NotificationResult SendNotification(NotificationMessage notification)
		{
			if (!ValidateNotification(notification))
			{
				return new NotificationResult
				{
					IsSuccess = false,
					Message = "Validation failed",
					SentAt = DateTime.Now
				};
			}

			switch (notification.Type)
			{
				case NotificationType.Email:
					return SendEmail(notification);

				case NotificationType.SMS:
					return SendSMS(notification);

				case NotificationType.Push:
					return SendPushNotification(notification);

				case NotificationType.Slack:
					return SendSlackMessage(notification);

				default:
					return new NotificationResult
					{
						IsSuccess = false,
						Message = "Unsupported notification type"
					};
			}
		}

		private NotificationResult SendEmail(NotificationMessage notification)
		{
			Console.WriteLine($"Sending Email to: {notification.Recipient}");
			Console.WriteLine($"Subject: {notification.Subject}");
			Console.WriteLine($"From: {notification.SenderEmail}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "Email sent successfully",
				TrackingId = $"EMAIL_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}

		private NotificationResult SendSMS(NotificationMessage notification)
		{
			Console.WriteLine($"Sending SMS to: {notification.PhoneNumber}");
			Console.WriteLine($"Message: {notification.Content}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "SMS sent successfully",
				TrackingId = $"SMS_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}

		private NotificationResult SendPushNotification(NotificationMessage notification)
		{
			Console.WriteLine($"Sending Push notification to device: {notification.DeviceToken}");
			Console.WriteLine($"App: {notification.AppId}");
			Console.WriteLine($"Title: {notification.Title}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "Push notification sent successfully",
				TrackingId = $"PUSH_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}

		private NotificationResult SendSlackMessage(NotificationMessage notification)
		{
			Console.WriteLine($"Sending Slack message to channel: {notification.Channel}");
			Console.WriteLine($"Content: {notification.Content}");

			return new NotificationResult
			{
				IsSuccess = true,
				Message = "Slack message sent successfully",
				TrackingId = $"SLACK_{Guid.NewGuid().ToString().Substring(0, 8)}",
				SentAt = DateTime.Now
			};
		}
		private bool ValidateNotification(NotificationMessage notification)
		{
			switch (notification.Type)
			{
				case NotificationType.Email:
					return !string.IsNullOrEmpty(notification.Recipient) &&
						   !string.IsNullOrEmpty(notification.Subject) &&
						   notification.Recipient.Contains("@");

				case NotificationType.SMS:
					return !string.IsNullOrEmpty(notification.PhoneNumber) &&
						   notification.PhoneNumber.Length >= 10;

				case NotificationType.Push:
					return !string.IsNullOrEmpty(notification.DeviceToken) &&
						   !string.IsNullOrEmpty(notification.AppId);

				case NotificationType.Slack:
					return !string.IsNullOrEmpty(notification.Channel) &&
						   !string.IsNullOrEmpty(notification.SlackToken);

				default:
					return false;
			}
		}
	}
}
