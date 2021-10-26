using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Toppings
{
    public class Eggplant : ITopping
    {
        public string Description { get; private set; }
        public Eggplant()
        {
            Description = "Eggplants without calories";
        }
    }
}
