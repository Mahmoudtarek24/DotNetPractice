using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExamples.operator_overloading
{
	public class CartItem
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }
	
		public Money TotalPrice => Product.Price*Quantity;	
	}
}
