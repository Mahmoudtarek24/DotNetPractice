using Dependency_Injection_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Tight_Coupling.Inheritance_Coupling
{
	internal class CustomerRepository : BaseRepository
	{
		public override void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public override void Save(object entity)
		{
			var customer = (Customer)entity; 
			ValidateEntity(customer); 
		}
	}
}
