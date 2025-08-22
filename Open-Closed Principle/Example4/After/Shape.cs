using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example4.After
{
	/// <summary>
	/// on this structure class is extensible we can add classes without modify on main class  
	/// 1- Open for extension: You can add TriangleShape, PentagonShape, without touching existing code
	/// 2- Closed for modification: Your AreaCalculator and existing shapes don't need changes
	/// </summary>
	public abstract class Shape
	{
		public abstract double CalculateArea();
		public abstract double CalculatePerimeter();
		public abstract void PrintShapeInfo();
	}
}
