using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);

        // To make custom model validation in employeecontroller
        Task<Employee> GetEmployeeByEmail(string email);

        //Search employees by name and gender
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);

    }
}
