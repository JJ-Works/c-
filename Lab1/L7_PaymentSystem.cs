/*
2. An online payment system can also use interfaces to handle multiple payment methods. 
Create an interface IPayment with a method Pay(double amount). 
Then implement it in classes like EsewaPayment and KhaltiPayment, each handling payment in its own way. 
A Checkout class can have a method that accepts an IPayment object and calls the payment method. 
In the main program, different payment options can be passed, showing flexibility and real-world use of interfaces.
*/

using System;

namespace Lab1
{
    public interface IPayment
    {
        void Pay(double amount);
    }

    class L7_EsewaPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Esewa: Connecting to secure gateway...");
            Console.WriteLine($"Esewa: Payment of Rs. {amount} successful. Transaction ID: {Guid.NewGuid().ToString().Substring(0, 8)}");
        }
    }

    class L7_KhaltiPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Khalti: Verifying wallet balance...");
            Console.WriteLine($"Khalti: Rs. {amount} deducted from your Khalti wallet.");
        }
    }

    class L7_Checkout
    {
        public void ProcessOrder(IPayment paymentMethod, double totalAmount)
        {
            Console.WriteLine("Checkout: Initializing order processing...");
            paymentMethod.Pay(totalAmount);
            Console.WriteLine("Checkout: Order confirmed. Thank you for your purchase!");
        }
    }
}
