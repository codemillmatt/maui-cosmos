namespace CosmosPizza.MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MenuPage>();
		builder.Services.AddSingleton<MenuPageViewModel>();

		// Data services
		builder.Services.AddSingleton<IMenuDataService>(new LocalMenuData());

		// Other services
		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		return builder.Build();
	}
}

