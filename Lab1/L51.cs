/*
Write a C# program that overloads the + operator 
to add two objects of a ComplexNumber class.
*/

using System;

class ComplexNumber
{
    public int Real;
    public int Imaginary;

    public ComplexNumber(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(
            c1.Real + c2.Real,
            c1.Imaginary + c2.Imaginary
        );
    }

    public void Display()
    {
        Console.WriteLine($"{Real} + {Imaginary}i");
    }
}

