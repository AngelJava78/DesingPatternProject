using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Doughs
{
    public class OriginalDough : IDough
    {
        public OriginalDough()
        {
            Description = "Original dough";
        }

        public string Description { get; private set; }

    }
}
