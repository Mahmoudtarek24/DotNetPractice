using Open_Closed_Principle.Example4.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example4.After
{
	public class RectangleShape : Shape
	{
		public int Width { get; set; }	
		public int Height { get; set; }	
		public override double CalculateArea() => Width * Height;
		public override double CalculatePerimeter() => 2 * (Width + Height);

		public override void PrintShapeInfo()
		{
			Console.WriteLine($"Rectangle: Width={Width}, Height={Height}");
		}
	}
}
