using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.Rest
{
    public class ProductAPI: IProductService
    {
        public List<Product> GetProductList()
        {
            var result = new List<Product>
            {
                new Product{ Id = 11, Name ="Ticket Restaurante Banda", Price = 11.11m},
                new Product{ Id = 12, Name ="Ticket Despensa Banda", Price = 12.12m},
                new Product{ Id = 14, Name ="Ticket Vestimenta Banda ", Price = 14.14m},
                new Product{ Id = 18, Name ="Ticket Regalo Banda", Price = 18.18m},
                new Product{ Id = 21, Name ="Ticket Restaurante Banda", Price = 21.21m},
                new Product{ Id = 32, Name ="Ticket Despensa Chip", Price = 32.32m},
            };
            return result;
        }
    }
}
