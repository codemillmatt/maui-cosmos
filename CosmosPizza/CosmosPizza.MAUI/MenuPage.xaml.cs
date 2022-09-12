namespace CosmosPizza.MAUI;

public partial class MenuPage : ContentPage
{
	MenuPageViewModel vm;
	public MenuPage(MenuPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
		vm = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}
