using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab1
{
    internal class Loop
    {
        public static void Looper()
        {
            Console.WriteLine("Counting from 1 to 10.\n");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
