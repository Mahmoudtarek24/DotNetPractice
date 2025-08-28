using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string CustomerEmail { get; set; }
		public decimal Amount { get; set; }
	}
}
