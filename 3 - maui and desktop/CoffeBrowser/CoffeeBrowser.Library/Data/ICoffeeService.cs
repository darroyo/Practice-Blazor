
namespace CoffeBrowser.Library.Data
{
    public interface ICoffeeService
    {
        Task<IEnumerable<Coffee>> GetCofeessAsync();
    }
}