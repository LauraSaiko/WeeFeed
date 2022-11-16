using System;
namespace WeeFeed.Models
{
	public class Ingredients
	{
		public int IngredientId { get; set; }
		public string IngredientName { get; set; }
		public int[]? elements { get; set; }
	}
}

