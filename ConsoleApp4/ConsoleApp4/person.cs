using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "Albert";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
