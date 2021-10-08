using FactoryMethod.Data;
using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var product = new Product
            {
                Id = 21,
                Name = "Ticket Restaurante Banda 21",
                Price = 21.2m
            };
            var data = new ProductData();

            data.Add(product);
            var list = data.GetAll();
            Console.WriteLine("Id\tName\tPrice");
            foreach (var prd in list)
            {
                Console.WriteLine($"{prd.Id}\t{prd.Name}\t{prd.Price.ToString("c")}");
            }
            //IDbAdapter adapter = DbAdapterFactory.GetDbAdapter(DatabaseType.MySql);
            //var connection = adapter.GetConnection();
        }
    }
}
