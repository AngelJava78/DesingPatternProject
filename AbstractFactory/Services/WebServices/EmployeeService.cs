using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.WebServices
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeeList()
        {
            var result = new List<Employee>
            {
                new Employee { Id = 1, Name="Angel Javier", Age = 42, Gender = "M"},
                new Employee { Id = 2, Name="Ernesto Torres", Age = 30, Gender = "M"},
                new Employee { Id = 3, Name="Luis Dávalos", Age = 62, Gender = "M"},
                new Employee { Id = 4, Name="Wendy Camargo", Age = 25, Gender = "F"},
            };
            return result;
        }
    }
}
