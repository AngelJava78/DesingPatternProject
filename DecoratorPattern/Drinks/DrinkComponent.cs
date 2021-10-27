using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Drinks
{
    public abstract class DrinkComponent
    {
        public abstract double Price { get; }
        public abstract string Description { get; }

    }
}
