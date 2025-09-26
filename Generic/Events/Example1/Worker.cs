using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Sharp.Events.Example1
{
	public delegate void WorkPerformedHandler(int hours, string type);
	public class Worker
	{
		public event WorkPerformedHandler WorkPerformed;		
		public void DoWork(int hours,string type)
		{
			WorkPerformed.Invoke(hours,type);
		}
	}
}
