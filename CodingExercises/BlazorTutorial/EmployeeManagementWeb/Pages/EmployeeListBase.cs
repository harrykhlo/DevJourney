using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWeb.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 0,
                FirstName = "John",
                LastName = "Hastings",
                Email = "john@email.com",
                DateOfBrith = new DateTime(1980, 10, 15),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 0, DepartmentName = "Department 0" },
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "sam@email.com",
                DateOfBrith = new DateTime(1981, 12, 15),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Department 1" },
                PhotoPath = "images/sam.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@email.com",
                DateOfBrith = new DateTime(1985, 12, 18),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 2, DepartmentName = "Department 2" },
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@email.com",
                DateOfBrith = new DateTime(1971, 11, 25),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Department 3" },
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
