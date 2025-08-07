using ExceptionHandlingPractice.InnerException.Business_Layer;
using ExceptionHandlingPractice.InnerExceptionExample2.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExceptionHandlingPractice.InnerExceptionExample2
{
	public class BorrowController
	{
		public LibraryService libraryService = new LibraryService();

		public ApiResponse BorrowBook(int bookId, int userId)
		{
			try
			{
				libraryService.BorrowBook(bookId,userId);
				return new ApiResponse { Success = true, Message = "User Borrow Successfully" };
			}
			catch (Exception ex)
			{
				return new ApiResponse 
				{ 
					Success = false, 
					Message = "Failed to borrow book",
					ErrorDetails= AddAllErrors(ex)
				};
			}
		}
		private List<string> AddAllErrors(Exception ex)
		{
			var errors= new List<string>();	
			var currentExcp= ex;

			while (currentExcp != null) {
				errors.Add(currentExcp.Message);	
				currentExcp= currentExcp.InnerException;
			}
			return errors;	
		}
	}
}
