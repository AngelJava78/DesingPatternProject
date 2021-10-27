using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Drinks
{
    public class ExpressCoffee : DrinkComponent
    {
        public override double Price => 70;
        public override string Description => "Express Coffee";
    }
}