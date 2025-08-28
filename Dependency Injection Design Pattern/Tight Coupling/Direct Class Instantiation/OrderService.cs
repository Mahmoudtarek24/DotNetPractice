using Dependency_Injection_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Tight_Coupling.Direct_Class_Instantiation
{
	public class OrderService
	{
		private EmailNotifier emailNotifier;
		private PayPalPaymentProcessor paymentProcessor;
		public OrderService()
		{
			emailNotifier = new EmailNotifier();	
			paymentProcessor = new PayPalPaymentProcessor();	
		}
		public void ProcessOrder(Order order)
		{
			paymentProcessor.ProcessPayment(order.Amount);
			emailNotifier.SendConfirmation(order.CustomerEmail);
		}
	}
}
