using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Sauces
{
    public class Olive : ISauce
    {
        public string Description { get; private set; }
        public Olive()
        {
            Description = "Olive tomato sauce";
        }
    }
}
