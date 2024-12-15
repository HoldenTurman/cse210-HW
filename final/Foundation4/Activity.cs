using System;
using System.Collections.Generic;

class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return string.Format("{0:dd MMM yyyy} Activity ({1} min)", GetDate(), GetMinutes());
    }
}
