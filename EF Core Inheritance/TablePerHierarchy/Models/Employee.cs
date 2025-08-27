using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerHierarchy.Models
{
	public abstract class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime HireDate { get; set; }
		public decimal BaseSalary { get; set; }
	}
}
