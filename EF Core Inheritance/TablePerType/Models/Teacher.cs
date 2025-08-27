using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerType.Models
{
	public class Teacher :Person
	{
		public string Subject { get; set; }
	}
}
