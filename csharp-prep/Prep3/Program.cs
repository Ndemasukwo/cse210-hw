using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");        

        // Console.WriteLine($"What is the magic number? {magicNum}");
        // Console.Write("What is your guess? ");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // string response = Console.ReadLine();
        // int guess = int.Parse(response);
        
        int magicNum = -1;

        while (magicNum != number)
        {
            // Console.WriteLine($"What is the magic number? {magicNum}");
            Console.Write("What is your guess? ");
            magicNum = int.Parse(Console.ReadLine());
        
            if (number > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (number < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            // Console.WriteLine($"What is the magic number? {magicNum}");
            // Console.Write($"What is your guess? ");
            // response = Console.ReadLine();
            // guess = int.Parse(response);
        }       
    }   
}