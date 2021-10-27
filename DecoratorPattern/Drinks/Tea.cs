using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Drinks
{
    public class Tea : DrinkComponent
    {
        public override double Price => 30;

        public override string Description => "Classic Tea";
    }
}
