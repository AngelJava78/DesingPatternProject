using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.Rest
{
    public class EmployeeAPI : IEmployeeService
    {
        public List<Employee> GetEmployeeList()
        {
            var result = new List<Employee>
            {
                new Employee { Id = 1, Name="Angel Javier", Age = 42, Gender = "M"},
                new Employee { Id = 2, Name="Zulidany Hernández", Age = 44, Gender = "F"},
                new Employee { Id = 3, Name="Rubí Javier", Age = 19, Gender = "F"},
                new Employee { Id = 4, Name="Perla Javier", Age = 17, Gender = "F"},
                new Employee { Id = 5, Name="Angélica Javier", Age = 16, Gender = "F"},
            };
            return result;
        }
    }
}
