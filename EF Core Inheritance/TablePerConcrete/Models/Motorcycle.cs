using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerConcrete.Models
{
	public class Motorcycle : Vehicle
	{
		public bool HasBasket { get; set; }
	}
}
