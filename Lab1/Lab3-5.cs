using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Lab1
{
    internal class Lab3_5
    {
        public void Transpose()
        {
            Console.WriteLine("Write a C# program that transposes a given 3x3 matrix.");

            int[,] original = new int[3, 3];
            int[,] transposed = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"For index: [{i}, {j}]: ");

                    original[i,j] = Convert.ToInt32(Console.ReadLine());
                    transposed[j,i] = original[i,j];
                }
            }

            Console.WriteLine("\nOriginal Matrix\n\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ original[i,j]}\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nTransposed Matrix\n\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{transposed[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

        }
        }
    }

