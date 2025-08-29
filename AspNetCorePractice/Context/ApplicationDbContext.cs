using Microsoft.EntityFrameworkCore;

namespace AspNetCorePractice.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }
	}
}
