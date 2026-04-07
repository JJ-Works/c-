using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class TemperatureC2f
    {
        public static double ToFahrenheit(double temperature)
        {
            return (9 / 5) * temperature + 32;
        }
    }
}
