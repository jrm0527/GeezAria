namespace Geez_Aria.Models
{
	public class PizzasModel
	{
		public string? ImageTitle { get; set; }
		public string? PizzaName { get; set; }
		public float BasePrice { get; set; } = 2;
		public bool TomatoSauce { get; set; }
		public bool Cheese { get; set; }
		public bool Pepperoni { get; set; }
		public bool Mushroom { get; set; }
		public bool Tuna { get; set; }
		public bool Pineapple { get; set; }
		public bool Bacon { get; set; }
		public bool GreenPepper { get; set; }
		public bool Onion { get; set; }
		public bool Sausage { get; set; }
		public bool Ham { get; set; }
		public bool Beef { get; set; }

		public float FinalPrice { get; set; }
	}
}
