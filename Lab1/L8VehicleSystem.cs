/*
3. A vehicle system can be implemented using an abstract class. 
Create an abstract class Vehicle with an abstract method Start() and a non-abstract method FuelType(). 
Then create classes like Car and Bike that override the Start() method. 
In the main program, create objects and call both methods. 
This shows how abstract and normal methods can be used together.
*/

using System;

namespace Lab1
{
    abstract class Vehicle
    {
        public abstract void Start();
        public void FuelType() => Console.WriteLine("Fuel Type: Petrol/Diesel");
    }

    class Car : Vehicle
    {
        public override void Start() => Console.WriteLine("Car starts with a key.");
    }

    class Bike : Vehicle
    {
        public override void Start() => Console.WriteLine("Bike starts with a kick.");
    }
}
