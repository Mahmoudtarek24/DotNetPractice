using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example3.After
{
	public class MultipleChoiceQuestion : Question
	{
		public List<string> Choices { get; set; } = new List<string>();
		public override void Print()
		{
			Console.WriteLine($"{Title} [{Mark}]");

			foreach (var choice in Choices)
				Console.WriteLine($"  {choice}");
		}
	}
}
