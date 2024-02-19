using BethanysPieShopHRM.App;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.App.State;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:7039/"));//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>(); ;
builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress = new Uri("https://localhost:7039/"));//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>(); ;
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress = new Uri("https://localhost:7039/"));//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>(); ;

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApplicationState>();

await builder.Build().RunAsync();
