using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        public bool showFooter { get; set; } = true;

        protected async override Task OnInitializedAsync()
        {
            Employees = (await employeeService.GetEmployees()).ToList();
        }

        protected int SelecitonEmployeeCount { get; set; } = 0;
        protected void EmployeeSelectionClicked(bool isSelected)
        {
            if (isSelected)
            {
                SelecitonEmployeeCount++;
            }
            else
            {
                SelecitonEmployeeCount--;
            }
        }

        protected async Task EmployeeDeleted()
        {
            Employees = (await employeeService.GetEmployees()).ToList();
        }

        //protected override async Task OnInitializedAsync()
        //{
        //    await Task.Run(LoadEmployees);
        //}

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(2000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/1.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/2.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/3.jpg"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "images/4.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
