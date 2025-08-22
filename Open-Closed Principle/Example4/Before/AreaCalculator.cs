using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example4.Before
{
	public class AreaCalculator
	{
		public double CalculateArea(Shape shape)
		{
			switch (shape.Type)
			{
				case ShapeType.Rectangle:
					return shape.Width * shape.Height;

				case ShapeType.Circle:
					return Math.PI * shape.Radius * shape.Radius;

				case ShapeType.Triangle:
					return 0.5 * shape.Base * shape.Height;

				default:
					throw new ArgumentException("Unknown shape type");
			}
		}

		public double CalculatePerimeter(Shape shape)
		{
			switch (shape.Type)
			{
				case ShapeType.Rectangle:
					return 2 * (shape.Width + shape.Height);

				case ShapeType.Circle:
					return 2 * Math.PI * shape.Radius;

				case ShapeType.Triangle:
					return 3 * shape.Base;

				default:
					throw new ArgumentException("Unknown shape type");
			}
		}

		public void PrintShapeInfo(Shape shape)
		{
			switch (shape.Type)
			{
				case ShapeType.Rectangle:
					Console.WriteLine($"Rectangle: Width={shape.Width}, Height={shape.Height}");
					break;

				case ShapeType.Circle:
					Console.WriteLine($"Circle: Radius={shape.Radius}");
					break;

				case ShapeType.Triangle:
					Console.WriteLine($"Triangle: Base={shape.Base}, Height={shape.Height}");
					break;

				default:
					Console.WriteLine("Unknown shape");
					break;
			}
		}
	}
}
