using CoffeeBrowser.Library.Data;
using CoffeeBrowser.WinForms.Auth;
using CoffeeBrowser.WinForms.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeBrowser.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider,
                CustomAuthStateProvider>();

            services.AddTransient<ICoffeeService, CoffeeService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(serviceProvider));
        }
    }
}