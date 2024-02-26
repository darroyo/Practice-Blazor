using CoffeeBrowser.Library.Data;
using CoffeeBrowser.Wpf.Auth;
using CoffeeBrowser.Wpf.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace CoffeeBrowser.Wpf
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif

            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider,
                CustomAuthStateProvider>();

            services.AddTransient<ICoffeeService, CoffeeService>();

            var serviceProvider = services.BuildServiceProvider();

            this.Resources.Add("ServiceProvider", serviceProvider);
        }
    }
}
