using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tasks.First_Task
{
	internal class DataContainer<T> where T : IComparable<T>
	{
		private T data;
		public T GetData() => data; 

		public void SetData(T newData) => data =newData;
		public bool HasData() => data != null;	
	
		public bool IsGreaterThan(T compareValue) =>data.CompareTo(compareValue) > 0;	
	}
}
