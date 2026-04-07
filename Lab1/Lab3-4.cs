using System;
using System.Collections.Generic;
using System.Text;


    internal class Lab3_4
    {
        public void addColumn()
        {
            Console.WriteLine("Write a C# program that takes a 3x3 matrix as input and prints the sum of each column.\n");

            int[,] matrix = new int[3, 3];
            int[] columnSum = { 0, 0, 0 };

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"For [{i}, {j}]: ");
                    matrix[i-1, j-1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The final matrix is :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {

                                   
                        columnSum[j] += matrix[i, j];
                    

                    Console.Write($" {matrix[i,j]} ");
                   
                }

            }

        Console.WriteLine("\n\n");
            for (int j = 0; j < 3; j++)
        {
            Console.WriteLine($"Sum of column {j} = {columnSum[j]}");

        }

    }
    
}
