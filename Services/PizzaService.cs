using BlazorApp.Models;
using System.Collections;
namespace BlazorApp.Services
{
    public class PizzaService
    {
        public async Task<IEnumerable<Pizza>> GetPizzas()
        {
            await Task.Delay(2000);
            return new List<Pizza>()
            {
                new Pizza { Name = "1 - The Baconatorizor", BasePrice =  11.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
                new Pizza { Name = "Buffalo chicken", BasePrice =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl="img/pizzas/meaty.jpg"},
                new Pizza { Name = "Veggie Delight", BasePrice =  11.5M, Description = "It's like salad, but on a pizza", ImageUrl="img/pizzas/salad.jpg"},
                new Pizza { Name = "Margherita", BasePrice =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl="img/pizzas/margherita.jpg"},
                new Pizza { Name = "Basic Cheese Pizza", BasePrice =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", ImageUrl="img/pizzas/cheese.jpg"},
                new Pizza { Name = "Classic pepperoni", BasePrice =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl="img/pizzas/pepperoni.jpg" }
            };
        }
    }
}