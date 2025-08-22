using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example3.After
{
	public class Quiz
	{
		public List<Question> Questions { get; }

		public Quiz(List<Question> questions)
		{
			this.Questions = questions;
		}

		public void Print()
		{
			foreach (var q in Questions)
				q.Print();

		}
	}
}
