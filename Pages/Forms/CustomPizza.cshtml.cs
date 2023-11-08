using Geez_Aria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geez_Aria.Pages.Forms
{
	public class CustomPizzaModel : PageModel
	{
		[BindProperty]
		public PizzasModel Pizza { get; set; }
		public float PizzaPrice { get; set; }
		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			PizzaPrice = Pizza.BasePrice;

			if (Pizza.TomatoSauce) PizzaPrice += 1;
			if (Pizza.Cheese) PizzaPrice += 1;
			if (Pizza.Pepperoni) PizzaPrice += 2;
			if (Pizza.Mushroom) PizzaPrice += 1;
			if (Pizza.Tuna) PizzaPrice += 2;
			if (Pizza.Pineapple) PizzaPrice += 1;
			if (Pizza.Bacon) PizzaPrice += 2;
			if (Pizza.GreenPepper) PizzaPrice += 1;
			if (Pizza.Onion) PizzaPrice += 1;
			if (Pizza.Sausage) PizzaPrice += 2;
			if (Pizza.Ham) PizzaPrice += 2;
			if (Pizza.Beef) PizzaPrice += 2;


			return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
		}
	}
}
