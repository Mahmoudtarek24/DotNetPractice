using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerHierarchy.Models
{
	public class PartTimeEmployee :Employee
	{
		public int HoursPerWeek { get; set; }
		public decimal HourlyRate { get; set; }
	}
}
