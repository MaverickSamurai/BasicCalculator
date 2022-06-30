using BasicCalculator.Class;
using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator1 calculator = new BasicCalculator1();
            calculator.Calculate(16, 8, "/");
        }
    }
}
