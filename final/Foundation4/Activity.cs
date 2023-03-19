public class Activity
{
    public DateTime date;
    public int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
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
        string summary = date.ToString("dd MMM yyyy") + " " + this.GetType().Name + " (" + minutes.ToString() + " min)";
        summary += " - Distance: " + GetDistance().ToString("F1") + " km";
        summary += ", Speed: " + GetSpeed().ToString("F1") + " kph";
        summary += ", Pace: " + GetPace().ToString("F1") + " min per km";
        return summary;
    }
}
