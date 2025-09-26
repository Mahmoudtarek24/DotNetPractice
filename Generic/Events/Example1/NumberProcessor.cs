using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Sharp.Events.Example1
{
	public delegate void NumberPrintedHandler(int number);
	public class NumberProcessor
	{
		int[] numbers = Enumerable.Range(0,1000).ToArray();		

		public event NumberPrintedHandler NumberFound;
		public void IterateNumbers()
		{
			foreach (var number in numbers)
				if (number == 4)
					NumberFound?.Invoke(number);
		}
	}
}
