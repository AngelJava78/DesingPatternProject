using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Pizzas
{
    public class HonoluluPizza : Pizza
    {
        public HonoluluPizza(string country)
        {
            description = "Honolulu";
            this.country = country;
        }
    }
}
