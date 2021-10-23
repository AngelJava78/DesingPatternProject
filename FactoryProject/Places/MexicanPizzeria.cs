using FactoryProject.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Places
{
    public class MexicanPizzeria : Pizzeria
    {
        public override Pizza CookPizza(string type)
        {
            Pizza pizza = null;
            if (type == "cold meats")
            {
                pizza = new ColdMeatsPizza("Mexico");
            }
            else if (type == "honolulu")
            {
                pizza = new HonoluluPizza("Mexico");
            }
            return pizza;
        }
    }
}
