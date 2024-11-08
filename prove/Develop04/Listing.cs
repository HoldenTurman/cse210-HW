using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> userResponses = new List<string>();

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    public void StartListing()
    {
        StartActivity();

        // Get duration from the user
        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please try again.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);

        // Select a random prompt
        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {prompt} --");
        Console.WriteLine("You may begin in: ");
        Countdown(5, true);

        DateTime startTime = DateTime.Now;  // Get the start time
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                userResponses.Add(response);

            }
        }

        Console.WriteLine($"You listed {userResponses.Count} items.");
        EndActivity();  // End the activity and show a summary
    }
}


