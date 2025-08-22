using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ExampleOne.After
{
	public class ProposedInvoice :Invoice
	{
		public override double GetInvoiceDiscount(double amount)
		{
			return amount -40;
		}
	}
}
