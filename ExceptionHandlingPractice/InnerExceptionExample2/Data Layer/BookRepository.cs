using ExceptionHandlingPractice.InnerException.Exceptions;
using ExceptionHandlingPractice.InnerExceptionExample2.Domain;
using ExceptionHandlingPractice.InnerExceptionExample2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.InnerExceptionExample2.Data_Layer
{
	public class BookRepository
	{
		public Book GetBookById(int bookId)
		{
			try
			{
				if(bookId<10)
					throw new TimeoutException("Database connection timeout");

				return new Book() { Id=1, IsAvailable=true, Title="Clean Code" };
			}
			catch(TimeoutException ex)
			{
				throw new DatabaseConnectionException("Error occur on data layer", ex);
			}
		}

		public bool CheckAvailability(int bookId)
		{
			try
			{
				if (bookId < 10)
					throw new BookNotAvailableException("the book not available for Borrowing");

				return true;	
			}
			catch(Exception ex)
			{
				throw new DatabaseConnectionException("Error occur on data layer", ex);
			}
		}

		public bool BorrowBook(int bookId,int userId)
		{
			try
			{
				if (bookId == 15 || bookId == 16)
					throw new BookNotAvailableException("the book is already borrowed by another user");

				if (bookId == 99)
					throw new TimeoutException("Database timeout during book update");

				return true;
			}
			catch (Exception ex)
			{
				throw new DatabaseConnectionException("Error occur on data layer", ex);
			}
		}
	}
}
