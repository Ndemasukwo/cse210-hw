using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 50)
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Recall a moment when you felt at peace with yourself."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel during this time?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
    }
}
