using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.NewFolder1.Composition
{
	public class Room
	{
		public string Name { get; set; }
		public double Size { get; set; }
		public Room(string name, double size)
		{
			Name = name;
			Size = size;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Room: {Name}, Size: {Size}m²");
		}
	}
}

