using System.Net.Http.Json;

namespace CoffeeBrowser.Maui.Data;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new();

    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>>(
            "https://www.thomasclaudiushuber.com/pluralsight/coffees.json");

        return coffees;
    }
}
