﻿using EmployeeModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
        }
        private void LoadEmployees()
        {
            Thread.Sleep(3000);

            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "john.smith@email.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.png"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bob.smith@email.com",
                DateOfBirth = new DateTime(1990, 01, 01),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/bob.png"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Linda",
                LastName = "Smith",
                Email = "linda.smith@email.com",
                DateOfBirth = new DateTime(1970, 05, 20),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/linda.png"
            };

            Employees = new List<Employee> { e1, e2, e3 };
        }
    }
}
