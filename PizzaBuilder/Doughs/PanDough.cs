using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Doughs
{
    public class PanDough : IDough
    {
        public PanDough()
        {
            Description = "Pan dough";
        }

        public string Description { get; private set; }

    }
}
