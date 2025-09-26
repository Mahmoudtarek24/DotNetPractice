using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Sort_Complex_Type_By_Used_IComparer
{
	public class Employee : IComparable<Employee>	
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public int Salary { get; set; }

		public int CompareTo(Employee? other) => this.Salary.CompareTo(other.Salary);
	}
}
