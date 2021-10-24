using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Wheels
{
    public interface ITyres
    {
        int Rin { get; }
        string GetInfo();
    }
}
