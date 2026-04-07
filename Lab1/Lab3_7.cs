using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Lab3_7
    {
        public void JaggedMaxima()
        {
            int[][] jagArr = new int[][]
            {
                new int[] {9,0,2},
                new int[] {44,5,2},
                new int[] {1,2 }
            };
            int[] sum = new int[3];

            Console.WriteLine("The jagged Array:");

            for (int i = 0; i < jagArr.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.Write($"{jagArr[i][j]}\t");
                    sum[i] += jagArr[i][j];

                }
            }

            Console.Write("\n\nThe sum of row 1,2,3 respectively:");
            
            Console.WriteLine(string.Join(", ",sum));
        }
    }
}
