using CoffeBrowser.Maui.Data;
using Microsoft.AspNetCore.Components;

namespace CoffeBrowser.Maui.Components.Pages
{
    public partial class Coffees
    {
        public IEnumerable<Coffee>? coffees { get; set; } = null;

        [Inject]
        private ICoffeeService _ICoffeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            coffees = await _ICoffeeService.GetCofeessAsync();
        }
    }
}