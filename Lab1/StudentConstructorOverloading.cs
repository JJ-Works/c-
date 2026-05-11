using System;

class Student2
{
    string name;
    int age;

    public Student2()
    {
        name = "Unknown";
        age = 0;
    }

    public Student2(string name)
    {
        this.name = name;
        age = 0;
    }

    public Student2(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}