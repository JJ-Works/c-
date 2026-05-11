/*
2. A shape drawing system can use an abstract class to represent common behavior. 
Create an abstract class Shape with an abstract method Draw() and a normal method Display(). 
Then create classes like Circle and Rectangle that override the Draw() method. 
In the main method, call both methods using derived class objects. 
This demonstrates abstraction and method overriding.
*/

using System;

namespace Lab1
{
    abstract class Shape
    {
        public abstract void Draw();
        public void Display() => Console.WriteLine("Displaying shape...");
    }

    class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Circle.");
    }

    class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Rectangle.");
    }
}
