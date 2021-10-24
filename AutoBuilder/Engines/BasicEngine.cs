using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Engines
{
    public class BasicEngine : IEngine
    {
        public BasicEngine()
        {
            Specs = "4-cylinder engine";
        }
        public string Specs { get; private set; }
    }
}
