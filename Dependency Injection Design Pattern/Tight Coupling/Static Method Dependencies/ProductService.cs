using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Tight_Coupling.Static_Method_Dependencies
{
	internal class ProductService
	{
		public void AddProduct()
		{
			StaticLogger.Log("Product added successfully!");
		}
	}
}
