public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int timesRequired;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int timesRequired, int bonusPoints)
        : base(name, description, points)
    {
        this.timesRequired = timesRequired;
        this.bonusPoints = bonusPoints;
        this.timesCompleted = 0;
    }

  public override void DisplayGoal()
    {
        string completionStatus = (timesCompleted >= timesRequired) ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {name} - {description}: Completed {timesCompleted}/{timesRequired} times ({points} points per completion, {bonusPoints} point bonus on completion)");
    }



    public int CalculateTotalEarnedPoints()
    {
        int basePoints = timesCompleted * points;
        if (timesCompleted >= timesRequired)
        {
            basePoints += bonusPoints;
        }
    return basePoints;
    }


    public override int RecordEvent()
    {
        if (timesCompleted < timesRequired)
        {
            timesCompleted++;
            int earnedPoints = points;
            if (timesCompleted == timesRequired)
            {
                earnedPoints += bonusPoints;
            }
            return earnedPoints;
        }
        return 0;
    }

    public void SetTimesCompleted(int completed)
{
    timesCompleted = completed;
}



    public override string SaveGoal()
{
    return $"ChecklistGoal|{name}|{description}|{points}|{timesRequired}|{bonusPoints}|{timesCompleted}";
}

}









       











