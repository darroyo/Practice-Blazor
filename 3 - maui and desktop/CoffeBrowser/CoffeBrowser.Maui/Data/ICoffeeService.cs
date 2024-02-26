
namespace CoffeBrowser.Maui.Data
{
    public interface ICoffeeService
    {
        Task<IEnumerable<Coffee>> GetCofeessAsync();
    }
}