using System;

public class Entry 
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _generatedPrompt;
    public string _answer;

    public void DisplayEntry()
    {
    Console.WriteLine($"{_date} - {_generatedPrompt} \n{_answer}");
    }
}