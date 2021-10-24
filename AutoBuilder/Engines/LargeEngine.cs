using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Engines
{
    public class LargeEngine : IEngine
    {
        public LargeEngine()
        {
            Specs = "8-cylinder engine";
        }
        public string Specs { get; private set; }
    }
}
