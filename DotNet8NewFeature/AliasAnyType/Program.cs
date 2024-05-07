using System;
using System.Collections.Generic;

// Define aliases for custom types
using Point = (int x, int y);
using StringList = System.Collections.Generic.List<string>;
using Values = int[];
using IsMember = bool;
using Person = (string firstName, string lastName);

class Program
{
    static void Main()
    {
        // Call the Draw method with a Point alias
        Point point = (3, 7);
        Draw(point);

        // Call the LoopOverStrings method with a StringList alias
        StringList stringList = new List<string> { "Hello", "World", "from", "C#" };
        LoopOverStrings(stringList);

        // Call the DisplayPerson method with a Person alias and IsMember alias
        Person person = ("John", "Doe");
        IsMember isMember = true;
        DisplayPerson(person, isMember);

        // Call the LoopOverValues method with a Values alias
        Values values = new int[] { 10, 20, 30, 40, 50 };
        LoopOverValues(values);
    }

    // Method to draw a point
    static void Draw(Point point)
    {
        Console.WriteLine($"Point: {point.x}, {point.y}");
    }

    // Method to loop through a list of strings
    static void LoopOverStrings(StringList list)
    {
        Console.WriteLine("Strings in the list:");
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
    }

    // Method to display a person's name and membership status
    static void DisplayPerson(Person person, IsMember isMember)
    {
        Console.WriteLine($"Person: {person.firstName} {person.lastName}; Member: {isMember}");
    }

    // Method to loop through an array of values
    static void LoopOverValues(Values values)
    {
        Console.WriteLine("Values in the array:");
        foreach (int val in values)
        {
            Console.WriteLine(val);
        }
    }
}
