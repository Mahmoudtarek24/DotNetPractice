using Open_Closed_Principle.Example4.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example4.After
{
	public class CircleShape : Shape
	{
		public double Radius { get; set; }
		public override double CalculateArea() => Radius * Radius * Math.PI;
		
		public override double CalculatePerimeter() => 2 * Math.PI * Radius; 

		public override void PrintShapeInfo()
		{
			Console.WriteLine($"Circle: Radius={Radius}");
		}
	}
}
