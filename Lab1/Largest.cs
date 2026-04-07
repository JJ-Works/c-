using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Lab1
{
    internal class Largest
    {
        public static void Large(int a, int b)
         {
            if (a == b)
            {
                Console.WriteLine("They are equal.");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} is Larger than {a}");
            }
            else
            {
                Console.WriteLine($"{a} is Larger than {b}");
            }
        }
    }
}
