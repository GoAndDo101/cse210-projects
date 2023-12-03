using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your world?");
        string WorldName = Console.ReadLine();
        Console.WriteLine("Welcome to " + WorldName);
        Console.WriteLine("What would you like to do?");
        Console.WriteLine();
        Console.WriteLine("1. Create a Race");
        Console.WriteLine("2. Create a Character");
        Console.WriteLine("3. Create an event");
        Console.WriteLine("4. Create a location");
        Console.ReadLine();
    }
}