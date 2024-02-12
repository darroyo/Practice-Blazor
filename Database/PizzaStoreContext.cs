using Microsoft.EntityFrameworkCore;
using BlazorApp.Models;
namespace BlazorApp.Database;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Pizza> Pizzas { get; set; }
}