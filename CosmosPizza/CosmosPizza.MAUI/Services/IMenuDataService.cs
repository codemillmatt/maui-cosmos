using System;
namespace CosmosPizza.MAUI
{
	public interface IMenuDataService
	{
		public Task<List<MenuItem>> GetMenuItemsAsync();
	}
}

