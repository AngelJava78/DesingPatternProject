using AutoBuilder.Bodyworks;
using AutoBuilder.Engines;
using AutoBuilder.Wheels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuilder
{
    public class Product
    {
        private IEngine engine;
        private IBodywork bodywork;
        private ITyres tyres;
        public void AddEngine(IEngine engine)
        {
            this.engine = engine;
            Console.WriteLine($"We added new engine: {engine.Specs}");
        }
        public void AddBodywork(IBodywork bodywork)
        {
            this.bodywork = bodywork;
            Console.WriteLine($"We added new bodywork: {bodywork.Features}");
        }
        public void AddTyres(ITyres tyres)
        {
            this.tyres = tyres;
            Console.WriteLine($"We added new tyres: {tyres.GetInfo()}");
        }
        public void ShowAutoDescription()
        {
            Console.WriteLine("Your car has:");
            Console.WriteLine($"\tEngine: {engine.Specs}");
            Console.WriteLine($"\tBodywork: {bodywork.Features}");
            Console.WriteLine($"\tTyres: {tyres.GetInfo()}");

        }
    }
}
