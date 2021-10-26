using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Sauces
{
    public class Tomato : ISauce
    {
        public string Description { get; private set; }
        public Tomato()
        {
            Description = "Classic Tomato sauce";
        }

    }
}
