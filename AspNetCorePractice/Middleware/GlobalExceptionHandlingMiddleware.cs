using AspNetCorePractice.DtoResponse;
using AspNetCorePractice.Exceptions;
using System.Text.Json;

namespace AspNetCorePractice.Middleware
{
	public class GlobalExceptionHandlingMiddleware
	{
		private readonly RequestDelegate _next;
		public GlobalExceptionHandlingMiddleware(RequestDelegate next)
		{
			this._next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context);		

			}
			catch (Exception ex)
			{
				await HandleExceptionAsync(context, ex);
			}
		}
		public async Task  HandleExceptionAsync(HttpContext context, Exception exception)
		{
			var response= context.Response;
			response.ContentType = "application/json";
			var errorResponse = exception switch
			{
				BusinessException businessEx =>
				ErrorResponse.Error(businessEx.Message, businessEx.ErrorCode, businessEx.StatusCode), 
				
				BaseException basexEx => ErrorResponse.Error(basexEx.Message, basexEx.ErrorCode, basexEx.StatusCode),

				UnauthorizedAccessException authEx => 
				                      ErrorResponse.Error(authEx.Message,"UNAUTHORIZED",401),


                _=> ErrorResponse.Error(exception.Message , "INTERNAL_SERVER_ERROR",500)
			};

			response.StatusCode = errorResponse.StatusCode;
		    var jsonResponse = JsonSerializer.Serialize(errorResponse,new JsonSerializerOptions
			{
				PropertyNamingPolicy=JsonNamingPolicy.CamelCase, ////convert Properity name to camelCase
				WriteIndented = true,
			});
			await response.WriteAsync(jsonResponse);	
		}

	}
}
