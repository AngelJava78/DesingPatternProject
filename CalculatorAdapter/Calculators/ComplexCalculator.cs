using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdapter.Calculators
{
    public class ComplexCalculator
    {
        public decimal Sum(int a, int b)
        {
            var randomNumber = new Random().Next(1, 100);
            return a + b + randomNumber;
        }
    }
}
