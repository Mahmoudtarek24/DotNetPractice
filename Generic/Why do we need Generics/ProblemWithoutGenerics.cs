using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Why_do_we_need_Generics
{
	public class ProblemWithoutGenerics
	{
		public bool IsEqual(int x,int y) => x == y;	
		public bool IsEqual(string x , string y) => x.Equals(y);	

		/// if we think to used object as parameter will focus boxing and unboxing problem lead to consume resources
		/// and will be Tied only with operation valid to object 
		public bool IsEqual(object x,object y)=> x.Equals(y);

		/// will solve this problem replace of override method and used object as parameter by used generic 

		public bool IsEqual<T>(T X,T y) => X.Equals(y);
	}
}
