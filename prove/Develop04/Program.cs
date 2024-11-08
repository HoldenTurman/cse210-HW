
using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();

            

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    // Create a new Breathing activity with the duration
                    activity = new Breathing();
                    activity.StartActivity(); // Show the welcome message
                    Breathing breathingActivity = (Breathing)activity;
                    breathingActivity.StartBreathing(); // Start the breathing activity
                    break;
                case "2":
                    activity = new Reflecting();
                    Reflecting reflectingActivity = (Reflecting)activity;
                    reflectingActivity.StartReflecting();

                    break;
                case "3":
                    activity = new Listing();
                    Listing listingActivity = (Listing)activity;
                    listingActivity.StartListing();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


