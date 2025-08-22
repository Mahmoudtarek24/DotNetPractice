using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example4.After
{
	public class AreaCalculator
	{
		public void DisplayShapeDetails(List<Shape> shapes)
		{
			foreach (Shape shape in shapes)
			{
				shape.PrintShapeInfo();
				Console.WriteLine($"Area: {shape.CalculateArea():F2}");
				Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
			}
		}
	}
}
