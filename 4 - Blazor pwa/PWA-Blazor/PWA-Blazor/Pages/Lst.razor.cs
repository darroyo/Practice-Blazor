// <auto-generated/>
using Microsoft.AspNetCore.Components;

namespace PWA_Blazor.Pages
{
    public partial class Lst
    {
        public IEnumerable<int>? coffees { get; set; } = null;
        protected override async Task OnInitializedAsync()
        {
            coffees = Enumerable.Range(0, 100);
        }
    }
}