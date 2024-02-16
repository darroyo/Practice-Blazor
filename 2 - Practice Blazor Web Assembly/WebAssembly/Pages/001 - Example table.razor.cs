using WebAssembly.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace WebAssembly.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}
