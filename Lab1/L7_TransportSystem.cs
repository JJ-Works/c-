/*
1. A transport system can be designed using an interface in C#. 
Define an interface IVehicle with methods Start() and Stop(). 
Then create classes like Car and Bike that implement this interface and provide their own version of starting and stopping. 
In the Program class, create objects using the interface reference such as IVehicle v = new Car(); and call the methods. 
This demonstrates polymorphism where the same interface is used but behavior differs.
*/

using System;

namespace Lab1
{
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    class L7_Car : IVehicle
    {
        public string Model { get; set; } = "Sedan";

        public void Start()
        {
            Console.WriteLine($"{Model} Car: Engine ignited. Systems check complete.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Model} Car: Braking applied. Engine shut down.");
        }
    }

    class L7_Bike : IVehicle
    {
        public bool HasSidecar { get; set; } = false;

        public void Start()
        {
            Console.WriteLine("Bike: Kick-start engaged. Engine roaring.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike: Ignition turned off. Side stand deployed.");
        }
    }
}
