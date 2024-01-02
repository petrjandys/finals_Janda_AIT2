using finals_Janda_AIT1.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace finals_Janda_AIT1.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	   : base(options)
		{
		}

		public DbSet<Credit> Credits { get; set; }
	}
}
