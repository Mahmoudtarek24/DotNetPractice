using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerExceptionExample2.Domain
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public bool IsAvailable { get; set; }
		public int BorrowedByUserId { get; set; }

	}
}
