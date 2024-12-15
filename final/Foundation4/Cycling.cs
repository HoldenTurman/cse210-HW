class Cycling : Activity
{
    private double speed; // mph or kph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return string.Format("{0:dd MMM yyyy} Cycling ({1} min): Distance {2:F1} miles, Speed {3:F1} mph, Pace {4:F1} min per mile", 
                              GetDate(), GetMinutes(), GetDistance(), GetSpeed(), GetPace());
    }
}
