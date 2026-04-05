using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you did something hard.",
        "Think of a time you helped someone.",
        "Think of a time you were strong."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "How did you feel?",
        "What did you learn?",
        "Would you do it again?",
        "What made it special?"
    };

    public ReflectingActivity() 
        : base("Reflecting Activity",
        "Reflect on moments of strength.") { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nReflect on the following:");
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}