using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductComposite.Products
{
   public abstract class AbstractProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public AbstractProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public virtual decimal GetPrice()
        {
            return Price;
        }
    }
}
