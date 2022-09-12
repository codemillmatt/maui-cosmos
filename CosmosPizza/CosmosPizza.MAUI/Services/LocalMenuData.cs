using System;

namespace CosmosPizza.MAUI
{
	public class LocalMenuData : IMenuDataService
	{
		public LocalMenuData()
		{
		}

        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            await Task.Delay(1);

            return new List<MenuItem>
            {
                new MenuItem { ItemName = "Breadsticks", Description = "Delicious Breadsticks", Price = 1.99 },
                new MenuItem { ItemName = "Breadsticks 2", Description = "Delicious Breadsticks 2", Price = 2.99 }
            };
        }
    }
}

