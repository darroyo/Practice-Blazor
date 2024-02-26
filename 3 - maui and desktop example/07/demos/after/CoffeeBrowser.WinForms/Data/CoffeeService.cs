using CoffeeBrowser.Library.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CoffeeBrowser.WinForms.Data;

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
