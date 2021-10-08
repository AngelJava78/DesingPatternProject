using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Animal : ICloneable
    {
        public int Legs { get; set; }
        public string Nombre { get; set; }

        public Details Details { get; set; }
        public object Clone()
        {
            var result = this.MemberwiseClone() as Animal;
            result.Details = new Details
            {
                Breed = this.Details.Breed,
                Color = this.Details.Color
            };
            return result;
        }
    }
}
