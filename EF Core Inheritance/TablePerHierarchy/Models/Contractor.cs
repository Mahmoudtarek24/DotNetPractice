using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerHierarchy.Models
{
	public class Contractor :Employee
	{
		public DateTime ContractEndDate { get; set; }
		public string ContractCompany { get; set; }
	}
}
