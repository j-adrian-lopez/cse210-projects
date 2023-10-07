using System;
using System.IO; 

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    public string _file;

    public void DisplayEntries(){
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.WriteLine("");
    }
    public void SaveToFile() {
        Console.Write("Please enter the name of the output file: ");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
        foreach(Entry entry in _entries){
        outputFile.WriteLine($"{entry._date}|{entry._generatedPrompt}|{entry._answer}");
        }
    }
    }

    public List<Entry> LoadFromFile() {
        Console.Write("Please enter the name of the journal file: ");
        string fileName = Console.ReadLine() + ".txt";
        
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
        string[] parts = line.Split("|");

        Entry newEntry = new Entry();
        newEntry._date = parts[0];
        newEntry._generatedPrompt = parts[1];
        newEntry._answer = parts[2];

        entries.Add(newEntry);
        }
        return entries;
    }
}
