using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdapter.Calculators
{
    public class BasicCalculator 
    {
        public decimal Add(int a, int b)
        {
            return (decimal)a + b;
        }
    }
}
