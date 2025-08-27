using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerHierarchy.Models
{
	public class FullTimeEmployee :Employee
	{
		public decimal AnnualBonus { get; set; }
		public int VacationDays { get; set; }
	}
}
