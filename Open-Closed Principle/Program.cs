using Open_Closed_Principle.Example3.Before;
using Open_Closed_Principle.Example4.Before;

namespace Open_Closed_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TestExample3BeforeOpenClose();
		}
		public static void TestExample3BeforeOpenClose()
		{
			Quiz quiz = new Quiz(QuestionBank.Generate());
			quiz.Print(); 
		}
		public static void TestExample4BeforeOpenClose()
		{
			var shapes = new List<Shape>
	    	{
				new Shape { Type = ShapeType.Rectangle, Width = 5, Height = 10 },
				new Shape { Type = ShapeType.Circle, Radius = 3 },
				new Shape { Type = ShapeType.Triangle, Base = 4, Height = 6 }
		    };

			var calculator = new AreaCalculator();

			foreach (var shape in shapes)
			{
				calculator.PrintShapeInfo(shape);
				Console.WriteLine($"Area: {calculator.CalculateArea(shape):F2}");
				Console.WriteLine($"Perimeter: {calculator.CalculatePerimeter(shape):F2}");
			}
		}
	}
}
