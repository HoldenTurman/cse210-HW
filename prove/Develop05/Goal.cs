using System;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract void DisplayGoal();
    public abstract int RecordEvent();
    public abstract string SaveGoal();
    public static Goal LoadGoal(string line)
    {
        string[] parts = line.Split('|');
        string goalType = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        if (goalType == "SimpleGoal")
        {
            return new SimpleGoal(name, description, points);
        }
        else if (goalType == "EternalGoal")
        {
            return new EternalGoal(name, description, points);
        }
        else if (goalType == "ChecklistGoal")
        {
            int timesRequired = int.Parse(parts[4]);
            int bonusPoints = int.Parse(parts[5]);
            int timesCompleted = parts.Length > 6 ? int.Parse(parts[6]) : 0; // Handle old files

            var checklistGoal = new ChecklistGoal(name, description, points, timesRequired, bonusPoints);
            checklistGoal.SetTimesCompleted(timesCompleted); // Restore progress
            return checklistGoal;
        }




        return null;
    }
}















