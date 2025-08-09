namespace AspNetCorePractice.Exceptions
{
	public class BusinessException :BaseException
	{
		private string? _message;	

		public BusinessException(string message,int statusCode,string errorCode) : base(message, statusCode, errorCode)
		{
			_message = message;	
		}

		public BusinessException() { }

		public override string Message => _message ?? "Error occurred in Business layer";
	}
}