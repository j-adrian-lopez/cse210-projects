using System;

public class PromptGenerator
{
    public string[] _prompts = {
        "What was the strongest feeling you had today? ",
        "What were your activities today? ",
        "Is there anything you wished you accomplished today? ",
        "What are your plans for tomorrow?",
        "What did you like best of today?",
        "What people did you meet today?"
    };

    public string GeneratePrompt()
    {
        Random randomInt = new();
        int index = randomInt.Next(0, _prompts.Length);
        return _prompts[index];
        }

}