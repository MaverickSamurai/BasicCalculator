using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Class
{
    class BasicCalculator1 : IBasicCalculator
    {
        public int number1;
        public int number2;
        public string operate;


        public void Calculate(int num1, int num2, string operation)
        {
            number1 = num1;
            number2 = num2;
            operate = operation;
            {
                if (operation == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (operation == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (operation == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (operation == "/")
                {
                    Console.WriteLine(num1 / num2);
                }

            }
        }
    }
}
