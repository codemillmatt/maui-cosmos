using System;
namespace CosmosPizza.MAUI
{
	public class Order
	{
		public Order()
		{
		}

		public DateTime DatePlaced { get; set; }
		public MenuItem ItemOrdered { get; set; }
		public int LoyaltyPointsEarned { get; set; }
	}
}

