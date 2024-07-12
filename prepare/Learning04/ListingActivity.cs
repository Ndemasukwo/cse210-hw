using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing", "This activity will help you list things that bring you joy.", 50)
    {
        _prompts = new List<string>
        {
            "List things you are grateful for.",
            "List people who have positively impacted your life."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        var list = GetListFromUser();
        _count = list.Count;
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        List<string> responses = new List<string>();

        for (int i = 0; i < 5; i++)  // Just as an example, we limit it to 5 entries
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        return responses;
    }
}
