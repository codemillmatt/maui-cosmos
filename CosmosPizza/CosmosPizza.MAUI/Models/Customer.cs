using System;
namespace CosmosPizza.MAUI
{
	public class Customer
	{
		public Customer()
		{
		}

		public string CustomerName { get; set; }
		public List<Order> Orders { get; set; }
		public int TotalLoyaltyPoints { get; set; }
	}
}

