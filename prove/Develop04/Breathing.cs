using System;

public class Breathing : Activity
{
    public Breathing(string activityName, string description) : base(activityName, description)
    {

    }

    public void RunBreathingActivity(int timer)
    {
        DateTime endTime = Interval(timer);
        int remainder = timer % 10;
        int breatheIn = (int)Math.Round(remainder * 0.4, 0);
        int breatheOut = (int)Math.Round(remainder * 0.6, 0);
        while(DateTime.Now.AddSeconds(9) <= endTime)
        {
            Console.Write("Breathe in... ");
            CounterAnimation(4);
            Console.WriteLine("");
            Console.Write("Now breathe out... ");
            CounterAnimation(6);
            Console.WriteLine("\n");
        } 
        if(DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            CounterAnimation(breatheIn);
            Console.WriteLine("");
            Console.Write("Now breathe out... ");
            CounterAnimation(breatheOut);
            Console.WriteLine("\n");
        }
    }

}