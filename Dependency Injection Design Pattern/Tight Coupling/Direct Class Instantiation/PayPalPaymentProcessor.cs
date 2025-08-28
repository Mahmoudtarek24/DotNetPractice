using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Tight_Coupling.Direct_Class_Instantiation
{
	public class PayPalPaymentProcessor
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine(amount);
		}
	}
}
