using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Example3.Before
{
	/// <summary>
	/// the Print method break open-close principle if we need and another type of question will modify open and modify 
	/// this method
	/// </summary>
	public class Quiz
	{
		public List<Question> Questions { get; }

		public Quiz(List<Question> questions)
		{
			this.Questions = questions;
		}
		public void Print()
		{
			foreach (var question in Questions)
			{
				Console.WriteLine($"{question.Title} [{question.Mark}]");
				if (question.QuestionType == QuestionType.MULTIPLECHOICE)
					foreach (var choice in question.Choices)
						Console.WriteLine($"  {choice}");
				
				if(question.QuestionType == QuestionType.WH)
				{
					Console.WriteLine("  _____________________________");
					Console.WriteLine("  _____________________________");
					Console.WriteLine("  _____________________________");
				}
				if (question.QuestionType == QuestionType.TRUEFALSE)
				{
					Console.WriteLine("  1. T");
					Console.WriteLine("  2. F");
				}
			}
		}
	}
}
