using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Shared.Model;
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
        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            Employee = (await EmployeeDataService.GetEmployeeDetails(Int32.Parse(EmployeeId)));
            if (Employee.Longitude.HasValue && Employee.Latitude.HasValue)
            {
                MapMarkers = new List<Marker>
                {
                    new Marker{Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = Employee.Longitude.Value, Y = Employee.Latitude.Value}
                };
            }
        }
    }
}
