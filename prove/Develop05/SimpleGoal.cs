public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isCompleted = false;
    }

    public override void DisplayGoal()
{
    Console.WriteLine($"{(isCompleted ? "[X]" : "[ ]")} {name} - {description} ({points} points)");
}


    public override int RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return points;
        }
        return 0;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal|{name}|{description}|{points}";
    }
}















