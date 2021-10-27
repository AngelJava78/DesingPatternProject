using DecoratorPattern.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class Milk : ToppingDecorator
    {
        public Milk(DrinkComponent drink) : base(drink)
        {

        }
        public override double Price => drink.Price + 10.0;

        public override string Description => $"{drink.Description}, Milk";
    }
}
