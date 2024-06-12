using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        // Use the variable after the "write" and before next variable

        Console.Write("What is your last name? ");        
        string last = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}