using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using WebAssembly.Models;
using WebAssembly.Services;

namespace WebAssembly.Pages 
{
    public partial class EmployeeDetails
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            Employee = (await EmployeeDataService.GetEmployeeDetails(Int32.Parse(EmployeeId)));
        }
    }
}
