using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Builders
{
    public interface IBuilder
    {
        void BuildEngine();
        void BuildBodywork();
        void BuildTyres();
        Product Car { get; }
    }
}
