public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {}

    public override void DisplayGoal()
    {
        Console.WriteLine($"{name} - {description}: [ ] ({points} points per completion)");
    }

    public override int RecordEvent()
    {
        return points;
    }

    public override string SaveGoal()
    {
        return $"EternalGoal|{name}|{description}|{points}";
    }
}












