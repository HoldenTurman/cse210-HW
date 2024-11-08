using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Start activity (this is what gets called to show the initial message)
    public void StartActivity()
    {
        Console.Clear();  // Clear the console before showing the activity details
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();  //Spacing
        Console.WriteLine(_description);
        Console.WriteLine(); //Spacing
        Console.WriteLine($"How long, in seconds, would you like for your session?");
    }

    // Other methods (e.g., EndActivity, Pause, Countdown) can go here

    public void EndActivity()
    {
        Console.WriteLine("Good job! You’ve completed the activity.");
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(5000); // Pause for 3 seconds before returning to the menu
    }




    protected void Countdown(int seconds, bool showNumber)
    {
       for (int i = seconds; i > 0; i--)
        {
            if(showNumber)
            {
            Console.Write($"\r{i} ");
            }
            Thread.Sleep(1000);      
        }
        Console.Write("\r   \r");
        Console.WriteLine(); // Move to a new line after countdown
    }
}
