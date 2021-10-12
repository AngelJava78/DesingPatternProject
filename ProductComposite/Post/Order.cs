using ProductComposite.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductComposite.Post
{
    public class Order
    {
        public long OrderId { get; set; }
        public string Customer { get; set; }
        public List<AbstractProduct> productList { get; set; }
        public Order(long orderId, string customer)
        {
            OrderId = orderId;
            Customer = customer;
            productList = new List<AbstractProduct>();
        }

        public void AddProduct(AbstractProduct product)
        {
            productList.Add(product);
        }

        public decimal GetTotal()
        {
            var total = 0m;
            foreach(var item in productList)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"OrderId: {OrderId}");
            Console.WriteLine($"Customer: {Customer}");
            Console.WriteLine($"Total: {GetTotal()}");
            Console.WriteLine("Products:");
            foreach(var item in productList)
            {
                Console.WriteLine($"\tName {item.Name}: {item.GetPrice()}");
            }
        }
    }
}
