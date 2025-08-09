namespace AspNetCorePractice.Exceptions
{
	public class DatabaseException : BaseException
	{
		public DatabaseException(string message ,int statusCode, string errorCode) 
			                                          : base (message ,statusCode, errorCode) { }
	}
}
