using System;

namespace Lab1
{
    internal class IncrementDecrementOperator
    {
        public static void IncDecOperation()
        {
            int i = 5;

            i++;
            Console.WriteLine("After Increment: " + i);

            i--;
            Console.WriteLine("After Decrement: " + i);
        }
    }
}