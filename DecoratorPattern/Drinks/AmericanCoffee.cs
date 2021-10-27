using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Drinks
{
    public class AmericanCoffee : DrinkComponent
    {
        public override double Price => 50;

        public override string Description => "American Coffee";
    }
}
