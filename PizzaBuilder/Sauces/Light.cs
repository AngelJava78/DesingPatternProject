using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Sauces
{
    public class Light : ISauce
    {
        public string Description { get; private set; }
        public Light()
        {
            Description = "Sauce without seasoning or salt";
        }
    }
}
