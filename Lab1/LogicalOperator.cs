using System;

namespace Lab1
{
    internal class LogicalOperator
    {
        public static void LogicalOperation()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("AND: " + (a && b));
            Console.WriteLine("OR: " + (a || b));
            Console.WriteLine("NOT: " + (!a));
        }
    }
}