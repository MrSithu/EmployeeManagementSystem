using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        public string Coordinates { get; set; }
        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }

        protected string TextBotton { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;
        protected void Click_Button()
        {
            if(TextBotton == "Hide Footer")
            {
                CssClass = "HideFooter";
                TextBotton = "Show Footer";
            }
            else
            {
                CssClass = null;
                TextBotton = "Hide Footer";
            }
        }
    }
}
