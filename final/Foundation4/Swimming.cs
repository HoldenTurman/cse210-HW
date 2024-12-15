class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // Convert meters to miles
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
        return string.Format("{0:dd MMM yyyy} Swimming ({1} min): Distance {2:F1} miles, Speed {3:F1} mph, Pace {4:F1} min per mile", 
                              GetDate(), GetMinutes(), GetDistance(), GetSpeed(), GetPace());
    }
}
