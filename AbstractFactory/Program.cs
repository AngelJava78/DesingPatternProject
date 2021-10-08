using AbstractFactory.Implementation;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IServicesStackAbstractFactory factory = ServiceStackAbstractFactory.CreateServiceFactory();
            var employeeService = factory.GetEmployeeService();
            var productService = factory.GetProductService();

            var employeeList = employeeService.GetEmployeeList();
            Console.WriteLine($"Id\tName\tAge\tGender");
            foreach (var emp in employeeList)
            {
                Console.WriteLine($"{emp.Id}\t{emp.Name}\t{emp.Age}\t{emp.Gender}");
            }
            var productList = productService.GetProductList();

            Console.WriteLine($"Id\tName\tPrice");
            foreach (var prod in productList)
            {
                Console.WriteLine($"{prod.Id}\t{prod.Name}\t{prod.Price.ToString("c")}");
            }
        }
    }
}
