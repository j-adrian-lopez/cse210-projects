using System;
using System.Diagnostics.Metrics;

public class Listing : Activity
{
    private List<string> _listingPrompts = new List<string>();
    private int _counter = 0;


    public Listing(string activityName, string description) : base(activityName, description)
    {
       string[] prompts =
       {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
       };
       foreach (string prompt in prompts)
       {
        _listingPrompts.Add(prompt);
       };
    }

    public string GetRandomPrompt()
    {
         Random randomGenerator = new Random();
         int randomInt = randomGenerator.Next(1, _listingPrompts.Count);
         return _listingPrompts[randomInt];
    }

    public void RunListingActivity(int timer)
    {
        PauseAnimation();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        CounterAnimation(5);
        Console.WriteLine("");

        DateTime endTime = Interval(timer);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter++;
        }
        Console.WriteLine($"You listed {_counter} items!");
    }
}