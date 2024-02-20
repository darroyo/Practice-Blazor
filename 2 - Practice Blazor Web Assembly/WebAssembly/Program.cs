using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAssembly;
using WebAssembly.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ApplicationState>(); 
builder.Services.AddScoped<BaseAddressAuthorizationMessageHandler_Custom>();

builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress =
new Uri("https://localhost:7039")).AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler_Custom>();
builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress =
new Uri("https://localhost:7039")).AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler_Custom>();
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress =
new Uri("https://localhost:7039")).AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler_Custom>();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Auth0", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "code";
    options.ProviderOptions.AdditionalProviderParameters.Add("audience", builder.Configuration["Auth0:Audience"]);
});

await builder.Build().RunAsync();
