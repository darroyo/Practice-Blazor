namespace CoffeBrowser.Maui.Data
{
    public class CoffeeService : ICoffeeService
    {
        public async Task<IEnumerable<Coffee>> GetCofeessAsync()
        {
            await Task.Delay(1000);
            return new[] {
                new Coffee
                {
                    Name = "Cappuccino",
                    Description = "Capucciono description"
                },
                new Coffee
                {
                    Name = "Cappuccino 2",
                    Description = "Capucciono 2 description"
                },
                new Coffee
                {
                    Name = "Cappuccino 3",
                    Description = "Capucciono 3 description"
                },
            };
        }
    }
}
