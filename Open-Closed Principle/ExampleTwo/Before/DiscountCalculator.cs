using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ExampleTwo.Before
{
	public class DiscountCalculator
	{
		public double CalculateDiscount(double price, CustomerType customerType)
		{
			return customerType switch
			{
				CustomerType.Regular => price * 0.1,
				CustomerType.Premium => price * 0.3,
				CustomerType.Newbie => price * 0.05,
				_=> throw new ArgumentOutOfRangeException(),
			};
		}
	}
}
