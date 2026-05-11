/*
5. A student grading system can be designed using an abstract class. 
Create an abstract class Student with an abstract method GetGrade() and a normal method ShowDetails(). 
Then create derived classes like ScienceStudent and ManagementStudent that implement grading logic differently. 
In the main method, create objects and display grades. 
This shows real-world application of abstraction.
*/

using System;

namespace Lab1
{
    abstract class Student
    {
        public string Name { get; set; } = string.Empty;
        public abstract string GetGrade();
        public void ShowDetails() => Console.WriteLine($"Student Name: {Name}");
    }

    class ScienceStudent : Student
    {
        public override string GetGrade() => "A+";
    }

    class ManagementStudent : Student
    {
        public override string GetGrade() => "A";
    }
}
