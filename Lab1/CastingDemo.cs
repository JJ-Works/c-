using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class CastingDemo
    {
        public void castDemo()
        {
            int intValue = 24;
            float floatValue = intValue;
            double doubleValue = floatValue;

            float secondFloat = 3.1415f;
            int secondInt = (int)secondFloat;
            long secondLong = (long)secondFloat;


            Console.WriteLine($"intValue = {secondInt}");
            Console.WriteLine($"floatValue = {secondLong}");
            Console.WriteLine($"doubleValue = {doubleValue}");

        }
    }
}
