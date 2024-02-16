using WebAssembly.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using WebAssembly.Services;

namespace WebAssembly.Pages
{
    public partial class _001_Employee_List
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public IEnumerable<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee overview 2";
        private string Description = "employee overview";

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees());
        }


        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
