// Build an online shopping checkout system where delegates handle
// the full process including calculating total price, applying
// discounts, and generating the final bill, while Func is used
// to compute totals and Predicate is used to validate eligible
// discount conditions.

using System;

public delegate void Checkout(double amount);

class CheckoutSystem
{
    public void Total(double amount)
    {
        Console.WriteLine("Total: " + amount);
    }

    public void Discount(double amount)
    {
        if (amount >= 5000)
            Console.WriteLine("Discount Applied");
        else
            Console.WriteLine("No Discount");
    }
}