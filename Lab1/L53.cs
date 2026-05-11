/*
Write a C# program that overloads * operator
to multiply Matrix by scalar.
*/

using System;

class Matrix
{
    public int Value;

    public Matrix(int value)
    {
        Value = value;
    }

    public static Matrix operator *(Matrix m, int num)
    {
        return new Matrix(m.Value * num);
    }

    public void Display()
    {
        Console.WriteLine(Value);
    }
}

