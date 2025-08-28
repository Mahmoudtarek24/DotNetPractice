using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.WITH_Dependency_Injection___Loosely_Coupled
{
	public class OrderService
	{
		private readonly INotificationService notificationService;
		public OrderService(INotificationService notificationService)
		{
			this.notificationService = notificationService;		
		}
	
		public void ProcessOrder(string customerContact, decimal amount)
		{
			// Process order logic...
			Console.WriteLine($"Processing order for ${amount}");

			 
			notificationService.SendNotification(customerContact,
				"Order Confirmation",
				$"Your order for ${amount} has been processed.");
		}
	}
}
