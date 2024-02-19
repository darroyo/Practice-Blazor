using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAssembly;
using WebAssembly.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = 
new Uri("https://localhost:7039"));
builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress =
new Uri("https://localhost:7039"));
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress =
new Uri("https://localhost:7039"));
builder.Services.AddScoped<ApplicationState>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
