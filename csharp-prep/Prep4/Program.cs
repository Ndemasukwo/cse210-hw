using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        int givenNum = -1;
        while (givenNum != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
            string response = Console.ReadLine();
            int userNum = int.Parse(response);

            if (givenNum != 0)
            {
                numbers.Add(givenNum);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}