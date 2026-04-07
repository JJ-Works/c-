using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Lab3_3
    {
        public void create()
        {
            Console.WriteLine("Write a C# program that takes a 3x3 matrix as input and prints the sum of each row.\n");

            int[,] matrix = new int[3, 3];
            int[] sumRow = { 0, 0, 0 }; 

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter for: [{i}, {j}] ");
                    matrix[i - 1, j - 1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < 3; j++)
                {
                    sumRow[i] += matrix[i, j];
                    Console.Write(matrix[i, j] + ":");
                }

            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n\nSum of row {i} =  {sumRow[i]}\t");

            }
        }
    }
}
