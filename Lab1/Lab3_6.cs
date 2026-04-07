using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lab1
{
    internal class Lab3_6
    {
        public void JaggedArray()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i}:");

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }

                Console.WriteLine(); 
            }
        }
        }
    }
