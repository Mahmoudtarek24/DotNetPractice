using ExceptionHandlingPractice.InnerExceptionExample2.Data_Layer;
using ExceptionHandlingPractice.InnerExceptionExample2.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerExceptionExample2.Business_Layer
{
	public class LibraryService
	{
		private BookRepository BookRepository = new BookRepository();

		public bool BorrowBook(int bookId, int userId)
		{
			try
			{
				CheckData(bookId, userId);
		        var result = BookRepository.BorrowBook(bookId, userId);	
			
				return result;	
			}
			catch(Exception ex) 
			{
				throw new BusinessRuleException("error occur when borrow book",ex);
			}
		}
		private void CheckData(int bookId, int userId)
		{
			try
			{
				if (bookId <= 0)
					throw new ArgumentException("Book Id must be greater than 0");

				if (userId <= 0) 
					throw new ArgumentException("User Id must be greater than 0");
				if (bookId ==1||bookId ==2)
					throw new BookNotAvailableException("Book Is not available ");

			}
			catch (Exception ex)
			{
				throw new System.ComponentModel.DataAnnotations.ValidationException("Error occure when validate data on Library services ", ex);
			}
		}
	}
}
