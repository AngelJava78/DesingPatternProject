using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Doughs
{
   public  class CrunchyDough : IDough
    {
        public CrunchyDough()
        {
            Description = "Crunchy dough";
        }

        public string Description { get; private set; }

    }
}
