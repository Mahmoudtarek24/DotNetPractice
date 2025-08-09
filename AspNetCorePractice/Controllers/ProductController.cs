using AspNetCorePractice.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCorePractice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetProductById(int Id)
		{
			return Id switch
			{
				var n when n >= 1 && n <= 10 => throw new DatabaseException("Database Connection Error", 500, "DATABASEERROR"),
				var n when n >= 11 && n <= 15 => throw new BusinessException("Id Not Found", 404, "NotFound"),
				var n when n >= 16 && n <= 20 => throw new BusinessException(null, 404, "NotFound"),
				_ => throw new Exception()
			};
		}
	}
}
