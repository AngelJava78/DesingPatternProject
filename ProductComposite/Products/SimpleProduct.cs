using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductComposite.Products
{
    public class SimpleProduct : AbstractProduct
    {
        public SimpleProduct(string name, decimal price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public string Brand { get; set; }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}
