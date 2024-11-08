using System;
using System.Collections.Generic;
using System.Threading;

public class Reflecting : Activity
{
    private List<string> reflectPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
    }

    public void StartReflecting()
    {
        StartActivity();

        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please try again.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);

        Random random = new Random();
        string prompt = reflectPrompts[random.Next(reflectPrompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {prompt} --");
        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();  // Wait for user to press Enter

        // Start asking reflection questions
        int secondsRemaining = _duration;
        while (secondsRemaining > 0)
        {
            string question = reflectQuestions[random.Next(reflectQuestions.Count)];
            Console.WriteLine(question);
            Countdown(10, false);  // Using a countdown method for timing
            secondsRemaining -= 5;
        }

        EndActivity();
    }
}



