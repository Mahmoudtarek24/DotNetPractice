using Generics.Tasks.First_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tasks.Task_2
{
	//class => should be reference type 
	//new() => public parameterless  constructor , can used with struct 
	public class Repository<T> where T : class, IIdentifiable , new() 
	{
		private List<T> listData = new List<T>();		
		public void Add(T item) => listData.Add(item);
		public List<T> GetAll() => listData;

		public bool Remove(int id)
		{
			var item = listData.FirstOrDefault(x => x.Id == id); 
			if (item is null)
				return false;
			return listData.Remove(item);
		}

		public int Count() => listData.Count;	
	}
}
/// complete with tasks , and example on internal generic