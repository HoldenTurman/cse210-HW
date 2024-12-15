class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        activities.Add(new Running(new DateTime(2024, 12, 12), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2024, 12, 13), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2024, 12, 14), 20, 40));

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
