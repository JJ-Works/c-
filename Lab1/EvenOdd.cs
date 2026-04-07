using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class EvenOdd
    {
        public static void EvenOddCheck(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                Console.WriteLine($"{a} is odd.");
            }
        }
    }
}
