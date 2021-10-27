using DecoratorPattern.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class ToppingDecorator : DrinkComponent
    {
        protected DrinkComponent drink;
        protected ToppingDecorator(DrinkComponent drink)
        {
            this.drink = drink;
        }

    }
}
