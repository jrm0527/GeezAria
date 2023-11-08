using Geez_Aria.Models;
using Microsoft.EntityFrameworkCore;

namespace Geez_Aria.Data
{
	public class ApplicationDBContext : DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
	}
}
