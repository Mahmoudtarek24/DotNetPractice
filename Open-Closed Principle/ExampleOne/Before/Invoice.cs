using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ExampleOne.Before
{
	/// <summary>
	/// this class will It breaks the open-close principle , if i want to add new type of Invoice Type i need to modify 
	/// on this class 
	/// with every change on this class we need to check previous and new functionalities working successfully 
	/// this because we need to ensure that the another developer or end user used functionality as expected 
	/// </summary>
	public class Invoice
	{
		public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
		{
			double finalAmount = 0;
			if (invoiceType == InvoiceType.FinalInvoice)
			{
				finalAmount = amount - 100;
			}
			else if (invoiceType == InvoiceType.ProposedInvoice)
			{
				finalAmount = amount - 50;
			}
			return finalAmount;
		}
	}
}
