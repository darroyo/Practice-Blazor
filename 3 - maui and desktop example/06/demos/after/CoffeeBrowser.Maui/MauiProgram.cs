using CoffeeBrowser.Library.Data;
using CoffeeBrowser.Maui.Auth;
using CoffeeBrowser.Maui.Data;
using Microsoft.AspNetCore.Components.Authorization;

namespace CoffeeBrowser.Maui;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		builder.Services.AddAuthorizationCore();
		builder.Services.AddScoped<AuthenticationStateProvider,
			CustomAuthStateProvider>();

		builder.Services.AddTransient<ICoffeeService, CoffeeService>();

		return builder.Build();
	}
}
