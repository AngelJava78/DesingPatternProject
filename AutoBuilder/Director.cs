using AutoBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder
{
    public class Director
    {
        public void BuildCar(IBuilder builder)
        {
            builder.BuildEngine();
            builder.BuildBodywork();
            builder.BuildTyres();
        }
    }
}
