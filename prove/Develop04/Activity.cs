using System;
using System.ComponentModel;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _timer;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _timer = 0;
    }

    public void DisplayMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
    }

    public string GetActivity()
    {
        return _activityName;
    }

    public void SetActivity(string activityName)
    {
        _activityName = activityName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetTimer()
    {
        int timer = int.Parse(Console.ReadLine());
        _timer = timer;
        Console.Clear();
        Console.WriteLine("Get ready...\n");
    }

    public int GetTimer()
    {
        return _timer;
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        PauseAnimation();
        Console.WriteLine($"You have completed another {_timer} seconds of the {_activityName} activity");
        PauseAnimation();
    }

    public void PauseAnimation(int time = 3)
    {
        List<string> spin = new List<string>();
        spin.Add("-");
        spin.Add("\\");
        spin.Add("|");
        spin.Add("/");
        spin.Add("-");
        spin.Add("\\");
        spin.Add("|");
        spin.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        // Stopwatch s = new Stopwatch();
        // s.Start();
        // while(s.Elapsed < TimeSpan.FromSeconds(time))
        // {
            while(DateTime.Now < endTime) 
            {
                string s = spin[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;

                if(i >= spin.Count)
                {
                    i = 0;
                }
            }
        // }
    }

    public void CounterAnimation(int seconds)
    {   
        for(int i = seconds; i > 0; i--)
        {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

        };


    }
    public DateTime Interval(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        return endTime;
    }

}