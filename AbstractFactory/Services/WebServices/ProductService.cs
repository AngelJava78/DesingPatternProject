using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.WebServices
{
    public class ProductService : IProductService
    {
        public List<Product> GetProductList()
        {
            var result = new List<Product>
            {
                new Product{ Id = 1, Name ="Antena para TV", Price = 189m},
                new Product{ Id = 2, Name ="Mouse Logitech M185", Price = 279m},
                new Product{ Id = 3, Name ="Impresora HP DeskJet 1275 ", Price = 599m},
                new Product{ Id = 4, Name ="Engrapadora eléctrica Swingline", Price = 999m},
                new Product{ Id = 5, Name ="Aspiradora Koblenz", Price = 879},

            };
            return result;
        }
    }
}
