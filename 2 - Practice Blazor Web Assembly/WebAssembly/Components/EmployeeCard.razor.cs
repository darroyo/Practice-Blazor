using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace WebAssembly.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            if (Employee.EmployeeId==22)
            {
                throw new Exception("Employee.EmployeeId==1");
            }
        }

        public void NavigateToDetails(Employee selectedEmployee)
        {

            NavigationManager.NavigateTo($"/employeedetails/{selectedEmployee.EmployeeId}");

        }
    }
}
