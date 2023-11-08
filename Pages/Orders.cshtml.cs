using Geez_Aria.Data;
using Geez_Aria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geez_Aria.Pages
{
	public class OrdersModel : PageModel
	{
		public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
		private readonly ApplicationDBContext _context;
		public OrdersModel(ApplicationDBContext context)
		{
			_context = context;
		}
		public void OnGet()
		{
			PizzaOrders = _context.PizzaOrders.ToList();
		}
	}
}
