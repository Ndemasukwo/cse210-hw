using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradePer = Console.ReadLine();
        int x = int.Parse(gradePer);

        string letter ="";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (x >= 70)
        {
            Console.WriteLine("You passed great job!");
        }
        else
        {
            Console.WriteLine("You didn't do so good, better luck next time.");
        }
    }
}