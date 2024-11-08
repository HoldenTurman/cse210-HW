using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void StartBreathing()
    {
        // Show the welcome message using StartActivity()
        StartActivity();

        int duration;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                _duration = duration; // Set the class-level _duration variable
                break; 
            }
            else
            {
                Console.WriteLine("Please enter a valid duration greater than 0.");
            }
        }

        // Clear the previous message and show countdown with breathing instructions
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);



        int secondsRemaining = _duration;
        while (secondsRemaining > 0)
        {
            Console.WriteLine("Breathe in... ");
            Countdown(5, true); // Using the new Countdown method for the inhale

            Console.WriteLine("Now breathe out... ");
            Countdown(5, true); // Using the new Countdown method for the exhale

            secondsRemaining -= 5; // Adjust based on inhale/exhale cycle
        }

        EndActivity(); // Conclude the activity
    }
}

