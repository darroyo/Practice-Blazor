using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using WebAssembly.Models;

namespace WebAssembly.Pages 
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            await base.OnInitializedAsync();
        }
    }
}
