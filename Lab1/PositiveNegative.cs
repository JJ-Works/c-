using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class PositiveNegative
    {
        public static string NegativePositive(int num)
        {
            if (num < 0)
            {
                return "negative";
            }
            else
            {
                return "positive";
            }
        }
    }
}
