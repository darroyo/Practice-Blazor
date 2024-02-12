using BlazorApp.Models;
using System.Collections;
using BlazorApp.Database;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class PizzaService
    {
        private readonly PizzaStoreContext _db;
        public PizzaService(PizzaStoreContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Pizza>> GetPizzas()
        {
            await Task.Delay(2000);
            return (await _db.Pizzas.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}