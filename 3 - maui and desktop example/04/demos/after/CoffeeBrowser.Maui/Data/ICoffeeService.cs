namespace CoffeeBrowser.Maui.Data;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
