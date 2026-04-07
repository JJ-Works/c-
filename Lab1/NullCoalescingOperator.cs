using System;

namespace Lab1
{
    internal class NullCoalescingOperator
    {
        public static void NullOperation()
        {
            string name = null;

            string result = name ?? "Guest";

            Console.WriteLine(result);
        }
    }
}