using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Wheels
{
    public class SuperTyres : ITyres
    {
        public SuperTyres()
        {
            Rin = 18;
        }

        public int Rin { get; private set; }

        public string GetInfo()
        {
            return $"{Rin}-inch wheels, aluminum wheels";
        }
    }
}
