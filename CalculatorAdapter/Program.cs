using CalculatorAdapter.Calculators;
using System;

namespace CalculatorAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICalculator calculator = new CalculatorAdapter();
            int a = 3;
            int b = 4;
            var result = calculator.Add(a, b);
            Console.WriteLine($"Sum of: {a} and {b} = {result}");
            
        }
    }
}
