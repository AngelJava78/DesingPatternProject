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
    public class FamilyBuilder : IBuilder
    {
        public Product Car { get; private set; }

        public FamilyBuilder()
        {
            Car = new Product();
        }

        public void BuildEngine()
        {
            Car.AddEngine(new BasicEngine());
        }

        public void BuildBodywork()
        {
            Car.AddBodywork(new BasicBodywork());
        }

        public void BuildTyres()
        {
            Car.AddTyres(new Tyres12());
        }
    }
}
