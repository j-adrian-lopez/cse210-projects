public class Senses : Activity
{
    private List<string> _sensesList = new List<string>();



    public Senses(string activityName, string description) : base(activityName, description)
    {
       string[] prompts =
       {
        "Look around. Notice and name five things that you can see.",
        "Think of your touch. Notice and name four things you can touch.",
        "Listen carefully to your surroundings. Notice and name three things you can hear.",
        "Notice and name two smells you recognize.",
        "Focus on your taste. Name one thing you taste right now, or just notice there is a taste in your mouth."
       };
       foreach (string prompt in prompts)
       {
        _sensesList.Add(prompt);
       };
    }


    public void RunSensesActivity(int timer)
    {
        DateTime endTime = Interval(timer);
        int timesplit = timer / 5;
        int index = 0;
        
        PauseAnimation();
        while(DateTime.Now < endTime)
        {
        Console.Write($"{_sensesList[index]} ");
        PauseAnimation(timesplit);
        Console.WriteLine("");
        index++;
        }
        Console.WriteLine("");
    }
}