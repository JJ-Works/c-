/*
4. A banking system can also use abstract classes. 
Create an abstract class Bank with an abstract method GetInterestRate(). 
Then create classes like NabilBank and NepalBank that return different interest rates. 
In the main method, display the interest rate for each bank. 
This highlights runtime behavior using abstract methods.
*/

using System;

namespace Lab1
{
    abstract class Bank
    {
        public abstract double GetInterestRate();
    }

    class NabilBank : Bank
    {
        public override double GetInterestRate() => 8.5;
    }

    class NepalBank : Bank
    {
        public override double GetInterestRate() => 7.0;
    }
}
