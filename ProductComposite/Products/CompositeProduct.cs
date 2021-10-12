using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductComposite.Products
{
    public class CompositeProduct : AbstractProduct
    {
        public CompositeProduct(string name, decimal price) : base(name, price)
        {
            ProductList = new List<AbstractProduct>();
        }

        public List<AbstractProduct> ProductList { get; set; }

        public void AddProduct(AbstractProduct product)
        {
            ProductList.Add(product);
        }

        public void RemoveProduct(AbstractProduct product)
        {
            ProductList.Remove(product);
        }

        public override decimal GetPrice()
        {
            decimal price = 0;
            foreach (var item in ProductList)
            {
                price += item.GetPrice();
            }
            return price;
        }
    }
}
