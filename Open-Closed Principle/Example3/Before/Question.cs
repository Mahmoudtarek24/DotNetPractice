using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example3.Before
{
	public class Question
	{
		public string Title { get; set; }
		public int Mark { get; set; }
		public QuestionType QuestionType { get; set; }
		public List<string> Choices { get; set; } = new List<string>();
	}
}
