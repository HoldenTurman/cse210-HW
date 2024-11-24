using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    totalPoints = RecordEvent(goals, totalPoints);
                    break;
                case "4":
                    SaveGoals(goals);
                    break;
                case "5":
                    LoadGoals(goals, ref totalPoints);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Enter the type of goal: 1 for Simple, 2 for Eternal, 3 for Checklist");
        string type = Console.ReadLine();
        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.WriteLine("Enter the number of times required to complete this goal: ");
            int timesRequired = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bonus points for completing the checklist: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, timesRequired, bonusPoints));
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    static int RecordEvent(List<Goal> goals, int totalPoints)
    {
        Console.WriteLine("Enter the index of the goal you completed (starting from 1): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            totalPoints += goals[index].RecordEvent();
            Console.WriteLine($"Goal completed. {totalPoints} total points.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }

        return totalPoints;
    }

    static void SaveGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to save.");
            return;
        }

        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveGoal());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals(List<Goal> goals, ref int totalPoints)
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = Goal.LoadGoal(line);
                    if (goal != null)
                    {
                        goals.Add(goal);

                        // Adjust totalPoints correctly based on the type of goal
                        if (goal is ChecklistGoal checklistGoal)
                        {
                            // Calculate points including bonus points if goal is complete
                            totalPoints += checklistGoal.CalculateTotalEarnedPoints();
                        }
                        else
                        {
                            totalPoints += goal.RecordEvent();
                        }
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

}












