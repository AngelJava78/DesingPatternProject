using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Drinks
{
    public class DecaffeinatedCoffee : DrinkComponent
    {
        public override double Price => 60;

        public override string Description => "Decaffeinated Coffee";
    }
}
