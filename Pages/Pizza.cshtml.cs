using Geez_Aria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geez_Aria.Pages
{
	public class PizzaModel : PageModel
	{
		public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
		{
			new PizzasModel()
			{
				ImageTitle="Margerita",
				PizzaName="Margerita",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				FinalPrice=4
			},
			new PizzasModel()
			{
				ImageTitle="Bolognese",
				PizzaName="Bolognese",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Beef=true,
				FinalPrice=5
			},
			new PizzasModel()
			{
				ImageTitle="Carbonara",
				PizzaName="Carbonara",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Pineapple=true,
				FinalPrice=15
			},
			new PizzasModel()
			{
				ImageTitle="Hawaiian",
				PizzaName="Hawaiian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Pineapple=true,
				FinalPrice=15
			},
			new PizzasModel()
			{
				ImageTitle="Mushroom",
				PizzaName="Mushroom",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Mushroom=true,
				FinalPrice=10
			},
			new PizzasModel()
			{
				ImageTitle="Pepperoni",
				PizzaName="Pepperoni",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Pepperoni=true,
				FinalPrice=10
			},
			new PizzasModel()
			{
				ImageTitle="Seafood",
				PizzaName="Seafood",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Tuna=true,
				FinalPrice=10
			},
			new PizzasModel()
			{
				ImageTitle="Vegetarian",
				PizzaName="Vegetarian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Mushroom=true,
				Pineapple=true,
				Onion=true,
				FinalPrice=10
			},
		};
		public void OnGet()
		{
		}
	}
}
