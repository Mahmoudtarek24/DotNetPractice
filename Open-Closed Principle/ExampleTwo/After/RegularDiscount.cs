using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ExampleTwo.After
{
	public class RegularDiscount : IDiscountStrategy
	{
		public double CalculateDiscount(double price) =>  price * 0.1;
	}
}
