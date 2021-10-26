using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Toppings
{
    public class Oregano:ITopping
    {
        public string Description { get; private set; }
        public Oregano()
        {
            Description = "Fresh oregano topping";
        }
    }
}
