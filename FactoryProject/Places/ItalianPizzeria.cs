using FactoryProject.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Places
{
    public class ItalianPizzeria : Pizzeria
    {
        public override Pizza CookPizza(string type)
        {
            Pizza pizza = null;
            if(type == "cold meats")
            {
                pizza = new ColdMeatsPizza("Italy");
            }
            else if(type=="honolulu")
            {
                pizza = new HonoluluPizza("Italy");
            }
            return pizza;
        }
    }
}
