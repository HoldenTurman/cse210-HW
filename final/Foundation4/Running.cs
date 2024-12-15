class Running : Activity
{
    private double distance; // miles or km

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return string.Format("{0:dd MMM yyyy} Running ({1} min): Distance {2:F1} miles, Speed {3:F1} mph, Pace {4:F1} min per mile", 
                              GetDate(), GetMinutes(), GetDistance(), GetSpeed(), GetPace());
    }
}
