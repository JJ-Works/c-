using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Factorial
    {
        public static int Fact(int num)
        {
            if(num == 0) return 1;
            return num * Fact(num - 1);
        }
    }
}
