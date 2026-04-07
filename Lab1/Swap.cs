using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Swap
    {
        public static void Swapped(int a, int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;
            (a, b) = (b, a);
            Console.WriteLine($"Swapped Values: \nFirst Number = {a} \nSecond Number = {b}");
        }
    }
}
