namespace AspNetCorePractice.DtoResponse
{
	public class ErrorResponse
	{
		public string Message { get; set; }
		public string ErrorCode { get; set; }
		public int StatusCode { get; set; }
		public DateTime Timestamp { get; set; } = DateTime.UtcNow;
	
		public static ErrorResponse Error(string message ,string errorCode ,int statusCode)
		{
			return new ErrorResponse
			{
				Message = message,
				ErrorCode = errorCode,
				StatusCode = statusCode
			};
		}
	}
}
