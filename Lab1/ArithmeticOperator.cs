using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class ArithmeticOperator
    {
        public static void ArithmeticOperation()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
        }
    }
}
