using AutoBuilder.Bodyworks;
using AutoBuilder.Engines;
using AutoBuilder.Wheels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder.Builders
{
    class SportBuilder : IBuilder
    {
        public Product Car { get; private set; }

        public SportBuilder()
        {
            Car = new Product();
        }


        public void BuildEngine()
        {
            Car.AddEngine(new LargeEngine());
        }

        public void BuildBodywork()
        {
            Car.AddBodywork(new SpecialBodywork());
        }

        public void BuildTyres()
        {
            Car.AddTyres(new SuperTyres());
        }
    }
}
