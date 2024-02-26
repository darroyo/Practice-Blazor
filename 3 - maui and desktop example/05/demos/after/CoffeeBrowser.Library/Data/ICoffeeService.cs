namespace CoffeeBrowser.Library.Data;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
