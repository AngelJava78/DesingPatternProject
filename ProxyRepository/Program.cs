using ProxyRepository.Data;
using ProxyRepository.Entities;
using ProxyRepository.Proxy;
using System;

namespace ProxyRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var repository = new CustomerRepositoryProxy();
            Session.CanSave = true;
            Session.CanGetAll = true;
            var customer1 = new Customer { Name = "Customer 1" };
            var customer2 = new Customer { Name = "Customer 2" };
            try
            {
                repository.Save(customer1);
                repository.Save(customer2);
                foreach (var c in repository.GetAll())
                {
                    Console.WriteLine($"Customer name: {c.Name}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.GetType()}");
                Console.WriteLine("Message:");
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
