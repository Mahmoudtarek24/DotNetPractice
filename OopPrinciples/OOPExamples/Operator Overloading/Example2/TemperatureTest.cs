using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExamples.operator_overloading.Example2
{
	public class TemperatureTest
	{
		public static void RunTests()
		{
			var temp1 = new Temperature(25, "C");
			var temp2 = new Temperature(77, "F");
			var temp3 = new Temperature(298.15, "K");
			var temp4 = new Temperature(30, "C");

			Console.WriteLine($"Temperature 1: {temp1}");
			Console.WriteLine($"Temperature 2: {temp2}");
			Console.WriteLine($"Temperature 3: {temp3}");
			Console.WriteLine($"Temperature 4: {temp4}");

			var sum = temp1 + temp4;
			Console.WriteLine($"Sum: {sum}");

			var diff = temp4 - temp1;
			Console.WriteLine($"Difference: {diff}");


		}
	}
}
