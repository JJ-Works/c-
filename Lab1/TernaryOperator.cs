using System;

namespace Lab1
{
    internal class ConditionalOperator
    {
        public static void ConditionalOperation()
        {
            int age = 20;

            string result = (age >= 18) ? "Adult" : "Minor";

            Console.WriteLine(result);
        }
    }
}