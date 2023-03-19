public class FitnessTracker
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 4.8));
        activities.Add(new StationaryBicycle(new DateTime(2022, 11, 03), 45, 30.0));
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 03), 60, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}