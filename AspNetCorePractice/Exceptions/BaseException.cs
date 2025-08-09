namespace AspNetCorePractice.Exceptions
{
	public abstract class BaseException :Exception
	{
		public int StatusCode { get; set; }	
		public string ErrorCode { get; set; }
		protected BaseException(string message,int statusCode,string errorCode) :base(message)
		{
			StatusCode = statusCode;	
			ErrorCode = errorCode;	
		}

		protected BaseException() { }
	}
}
