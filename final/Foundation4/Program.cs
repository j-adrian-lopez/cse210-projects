using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Running run = new Running(50, 12);
        Cycling cycling = new Cycling(45, 45);
        Swimming swimming = new Swimming(75, 40);

        activities.Add(run);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking\n");

        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}