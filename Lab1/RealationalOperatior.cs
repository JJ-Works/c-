using System;

namespace Lab1
{
    internal class RelationalOperator
    {
        public static void RelationalOperation()
        {
            int x = 5;
            int y = 8;

            Console.WriteLine("Equal: " + (x == y));
            Console.WriteLine("Not Equal: " + (x != y));
            Console.WriteLine("Greater: " + (x > y));
            Console.WriteLine("Less: " + (x < y));
            Console.WriteLine("Greater Equal: " + (x >= y));
            Console.WriteLine("Less Equal: " + (x <= y));
        }
    }
}