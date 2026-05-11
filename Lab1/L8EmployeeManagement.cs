/*
1. An employee management system can be designed using an abstract class. 
Create an abstract class Employee with an abstract method CalculateSalary(). 
Then create derived classes like FullTimeEmployee and PartTimeEmployee that implement salary calculation differently. 
In the main program, create objects of both and display their salaries. 
This shows how abstract classes define a common structure while allowing different implementations.
*/

using System;

namespace Lab1
{
    abstract class Employee
    {
        public string Name { get; set; } = string.Empty;
        public abstract double CalculateSalary();
    }

    class FullTimeEmployee : Employee
    {
        public override double CalculateSalary() => 50000;
    }

    class PartTimeEmployee : Employee
    {
        public override double CalculateSalary() => 20000;
    }
}
