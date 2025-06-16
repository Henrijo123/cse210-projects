using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];
        Running running = new Running("16 Jun 2025", 30, 20);
        Cycling cycling = new Cycling("15 May 2024", 20, 50);
        Swimming swimming = new Swimming("14 Jan 2023", 40, 200);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}