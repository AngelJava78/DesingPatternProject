using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Toppings
{
    public class Anchovy : ITopping
    {
        public string Description { get; private set; }
        public Anchovy()
        {
            Description = "Anchovies in oil";
        }
    }
}
