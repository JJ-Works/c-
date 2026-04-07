using System;

namespace Lab1
{
    internal class AssignmentOperator
    {
        public static void AssignmentOperation()
        {
            int n = 10;

            n += 5;
            Console.WriteLine("After += : " + n);

            n -= 3;
            Console.WriteLine("After -= : " + n);

            n *= 2;
            Console.WriteLine("After *= : " + n);

            n /= 4;
            Console.WriteLine("After /= : " + n);
        }
    }
}