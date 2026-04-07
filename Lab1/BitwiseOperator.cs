using System;

namespace Lab1
{
    internal class BitwiseOperator
    {
        public static void BitwiseOperation()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine("AND: " + (a & b));
            Console.WriteLine("OR: " + (a | b));
            Console.WriteLine("XOR: " + (a ^ b));
            Console.WriteLine("NOT: " + (~a));
            Console.WriteLine("Left Shift: " + (a << 1));
            Console.WriteLine("Right Shift: " + (a >> 1));
        }
    }
}