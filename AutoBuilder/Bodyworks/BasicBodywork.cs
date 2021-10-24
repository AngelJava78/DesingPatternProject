using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Bodyworks
{
    public class BasicBodywork : IBodywork
    {
        
        public BasicBodywork()
        {
            Features = "Metal bodywork";
        }
        public string Features { get; private set; }
    }
}
