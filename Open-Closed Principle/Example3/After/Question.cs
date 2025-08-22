using Open_Closed_Principle.Example3.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example3.After
{
	public abstract class Question
	{
		public string Title { get; set; }
		public int Mark { get; set; }
		public abstract void Print();
	}
}
