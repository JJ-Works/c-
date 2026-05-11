// Create a mini student management system where different delegate
// types are combined, including custom delegates for adding and
// updating student data, multicast delegates for generating reports,
// Func for grade calculation, Action for displaying information,
// and Predicate for filtering students based on performance.

using System;

public delegate void StudentDelegate(string name);

class StudentManagement
{
    public void Add(string name)
    {
        Console.WriteLine("Added: " + name);
    }

    public void Report(string name)
    {
        Console.WriteLine("Report: " + name);
    }
}