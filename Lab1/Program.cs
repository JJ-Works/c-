using System;
using System.ComponentModel;
using System.Xml;

namespace Lab1
{
    class Program
    {

        public static void Main(string[] args)
        {

            //Lab3_1
            //Write a C# program that takes N numbers as input, stores them in an array, and finds the maximum value.
            //Console.Write("Enter how many numbers do you need: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] numbersArr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"\nEnter the value for {numbersArr[i] + 1}: ");
            //    numbersArr[i] = Convert.ToInt32(Console.ReadLine());


            //}

            //Lab3_1 max = new Lab3_1();
            //max.MaximunNum(numbersArr);

            //Write a C# program that reverses a given array of integers.

            //int[] arr = [ 1,2,3,4,5,6,7];

            //Lab3_2 reverse = new Lab3_2();
            //reverse.reverseThis(arr);

            //Lab 3-3

            //Lab3_3 createMatrix = new Lab3_3();
            //createMatrix.create();

            //Lab3_4
            //Lab3_5 transposeMatrix = new Lab3_5();
            //transposeMatrix.Transpose();

            //Lab3_6
            //Lab3_6 jagged = new Lab3_6();
            //jagged.JaggedArray();

            //Lab3_7
            Lab3_7 jagSum = new Lab3_7();
            jagSum.JaggedMaxima();
        }
    }
}
