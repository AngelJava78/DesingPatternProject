using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Pizzas
{
    public class ColdMeatsPizza : Pizza
    {
        public ColdMeatsPizza(string country)
        {
            description = "Cold Meats";
            this.country = country;
        }
    }
}
