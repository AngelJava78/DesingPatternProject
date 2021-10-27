using DecoratorPattern.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class Sweetener : ToppingDecorator
    {
        public Sweetener(DrinkComponent drink) : base(drink)
        {

        }
        public override double Price => drink.Price + 5.0;

        public override string Description => $"{drink.Description}, Sweetener";
    }
}
