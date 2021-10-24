using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Bodyworks
{
    public class SpecialBodywork : IBodywork
    {
        public SpecialBodywork()
        {
            Features = "Carbon fiber bodywork";
        }
        public string Features { get; private set; }
    }
}
