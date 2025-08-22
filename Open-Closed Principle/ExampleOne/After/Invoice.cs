using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ExampleOne.After
{
	/// <summary>
	/// now if we need to add another type of Invoice create class and override only method without any testing for 
	/// previous functionality will test only new functionality
	/// </summary>
	public class Invoice
	{
		public virtual double GetInvoiceDiscount(double amount)
		{
			return amount;
		}
	}
}
