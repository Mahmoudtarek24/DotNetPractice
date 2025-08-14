using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.NewFolder1.Aggregation
{
	public class Student
	{
		public string Name { get; set; }
		public int Id { get; set; }

		public Student(string name, int id)
		{
			Name = name;
			Id = id;
		}

		public void Study()
		{
			Console.WriteLine($"{Name} is studying");
		}
	}
}
