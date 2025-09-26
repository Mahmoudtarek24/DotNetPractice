using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class MyGenericClass<T>
	{
		public T Value { get; set; }
		public MyGenericClass(T value)
		{
			this.Value = value;		
		}

		public bool IsEqual<T>(T x, T y) => x.Equals(y);
	
	}
}
