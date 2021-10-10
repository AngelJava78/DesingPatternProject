using CalculatorAdapter.Calculators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdapter
{
    public class CalculatorAdapter : ICalculator
    {
        
        public decimal Add(int a, int b)
        {

            var calculator = new ArrayCalculator();
            var numbers = new int[] { a, b };
            var result = calculator.Addition(numbers);
            return (decimal)result;
        }
    }
}
