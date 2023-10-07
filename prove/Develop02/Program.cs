using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        int reply;
        PromptGenerator newPrompt = new PromptGenerator();
        Journal newJournal = new Journal();
        do
        {
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
        Console.Write("\nWhat would you like to do? ");
        reply = int.Parse(Console.ReadLine());

        switch(reply)
        {
            case 1:
            Entry newEntry = new Entry();
            newEntry._generatedPrompt = newPrompt.GeneratePrompt();
            Console.WriteLine(newEntry._generatedPrompt);
            newEntry._answer = Console.ReadLine();
            newJournal._entries.Add(newEntry);
            break;
            
            case 2:
            newJournal.DisplayEntries();
            break;

            case 3:
            newJournal.SaveToFile();
            Console.WriteLine("");
            break;
            
            case 4:
            newJournal._entries = newJournal.LoadFromFile();
            Console.WriteLine("");
            break;

            case 5:
            Console.WriteLine("Thank you for using the journal! See you!\n");
            break;

            default:
            Console.WriteLine("Please choose a valid option.\n");
            break;
        }
        } while (reply != 5);


    }
}