using Generics.Tasks.First_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tasks.Task_2
{
	public class Book : IIdentifiable
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
	}
}
