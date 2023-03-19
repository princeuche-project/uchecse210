class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // km
    }

    public override double GetSpeed()
    {
        return GetDistance() / (minutes / 60.0); // km/h
    }

    public override double GetPace()
    {
        return minutes / GetDistance(); // min/km
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Swimming ({minutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}