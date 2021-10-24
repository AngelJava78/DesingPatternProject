using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Wheels
{
    class Tyres12 : ITyres
    {
        public Tyres12()
        {
            Rin = 12;
        }

        public int Rin {get; private set;}
        public string GetInfo()
        {
            return $"{Rin}-inch wheels";
        }
    }
}
