using WebAssembly.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace WebAssembly.Pages
{
    public partial class _001_Employee_List
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee overview 2";
        private string Description = "employee overview";

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }


        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
