using  System.ComponentModel.DataAnnotations;
namespace BlazorApp.Models;
public class Pizza
{
    public int Id { get; set; }
    [Required(ErrorMessage = "You must set a name for your pizza.")]
    [StringLength(5)]
    public string Name { get; set; }

    public decimal BasePrice { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

}  