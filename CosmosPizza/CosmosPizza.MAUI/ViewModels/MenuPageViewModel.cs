using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CosmosPizza.MAUI
{
	public partial class MenuPageViewModel : BaseViewModel
	{
		IMenuDataService _menuDataService;
		IConnectivity _connectivity;

		public ObservableCollection<MenuItem> MenuItems { get; } = new();

		public MenuPageViewModel(IMenuDataService menuDataService, IConnectivity connectivity)
		{
			Title = "Menus";
			_menuDataService = menuDataService;
			_connectivity = connectivity;			
		}

		[ObservableProperty]
		bool isRefreshing;

		[RelayCommand]
		async Task GetMenuItemsAsync()
		{
			if (IsBusy)
				return;

			try
			{
				if (_connectivity.NetworkAccess != NetworkAccess.Internet)
				{
					await Shell.Current.DisplayAlert("No Internet!", "Please check internet and try again.", "Ok");
					return;
				}

				IsBusy = true;

				var menuItems = await _menuDataService.GetMenuItemsAsync();

				if (MenuItems.Count() != 0)
					MenuItems.Clear();

				foreach (var item in menuItems)
				{
					MenuItems.Add(item);
				}

			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Unable to get menu items: {ex.ToString()}");
				await Shell.Current.DisplayAlert("Error!", ex.Message, "Ok");
			}
			finally
			{
				IsBusy = false;
				IsRefreshing = false;
			}
		}
    }
}

