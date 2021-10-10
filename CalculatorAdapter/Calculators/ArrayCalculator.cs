using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdapter.Calculators
{
    public class ArrayCalculator
    {
        public double Addition(int[] numbers)
        {
            var result = 0;
            foreach (var n in numbers)
            {
                result += n;
            }
            return result;
        }
    }
}
