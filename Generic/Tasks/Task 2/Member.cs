using Generics.Tasks.First_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tasks.Task_2
{
	internal class Member :IIdentifiable
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
