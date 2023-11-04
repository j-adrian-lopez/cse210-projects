using System;

public class Reflecting : Activity
{
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _questions = new List<string>();


    public Reflecting(string activityName, string description) : base(activityName, description)
    {
       string[] prompts =
       {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you prepared for a difficult task.",
        "Think of a time when you sacrificed to achieve a better end.",
        "Think of a time when you worked hard for a goal."
       };

       foreach (string prompt in prompts)
       {
        _reflectionPrompts.Add(prompt);
       };

       string[] questions = 
       {
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?",
       "What was the hardest thing of this experience, and how did you overcome it?",
       "How many people were blessed for your effort?",
       "How did this experience improve your life point-of-view?"
       };

       foreach (string question in questions)
       {
        _questions.Add(question);
       };
    }

    public string GetRandomPrompt()
    {
         Random randomGenerator = new Random();
         int randomInt = randomGenerator.Next(1, _reflectionPrompts.Count);
         return _reflectionPrompts[randomInt];
    }

    public string GetRandomQuestion()
    {
         Random randomGenerator = new Random();
         int randomInt = randomGenerator.Next(1, _questions.Count);
         return _questions[randomInt];
    }

    public void RunReflectingActivity(int timer)
    {
        PauseAnimation();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string reply = Console.ReadLine();
        while(reply != ""){
        Console.WriteLine("Please press enter.");
        reply = Console.ReadLine();
        }
        Console.WriteLine("Now ponder in each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CounterAnimation(5);
        Console.WriteLine("");

        DateTime endTime = Interval(timer);
        while(DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            PauseAnimation(10);
            Console.WriteLine("");
        }

    }

}