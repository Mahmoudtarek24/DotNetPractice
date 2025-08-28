using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.WITHOUT_Dependency_Injection___Tightly_Coupled
{
	public class OrderService
	{
		private EmailService _emailService;

		public OrderService()
		{
			// PROBLEM: OrderService is directly creating EmailService
			// This creates tight coupling
			_emailService = new EmailService();
		}
		public void ProcessOrder(string customerEmail, decimal amount)
		{
			Console.WriteLine($"Processing order for ${amount}");

			///PROBLEM her if i want to change from email to sms also i need to change code her ,an same time its 
			///violation open-close principle
			
			// Send confirmation email
			_emailService.SendEmail(customerEmail,
				"Order Confirmation",
				$"Your order for ${amount} has been processed.");
		}
	}
}
