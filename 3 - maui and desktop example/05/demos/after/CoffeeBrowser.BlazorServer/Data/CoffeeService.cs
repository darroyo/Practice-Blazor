using CoffeeBrowser.Library.Data;
using System.Net.Http.Json;

namespace CoffeeBrowser.BlazorServer.Data;

public class CoffeeService : ICoffeeService
{
    private readonly IHttpClientFactory _factory;

    public CoffeeService(IHttpClientFactory factory)
    {
        _factory = factory;
    }

    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
        using var httpClient = _factory.CreateClient();

        var coffees = await httpClient.GetFromJsonAsync<IEnumerable<Coffee>>(
            "https://www.thomasclaudiushuber.com/pluralsight/coffees.json");

        return coffees;
    }
}
