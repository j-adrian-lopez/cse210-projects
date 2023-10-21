using System;
using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Word>_text = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    // constructors that use Reference with separate parameters
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public Scripture(string book, int chapter, int startVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse);

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public void GetRendered()
    {
        Console.Clear();
        Console.WriteLine(_reference.RenderRef());
        foreach (Word word in _text)
        {  
            Console.Write($"{word.GetRenderedWord()} ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random randomInt = new Random();
        int index = randomInt.Next(0, _text.Count);


        while(_text[index].IsHidden() != false)
        {
            index = randomInt.Next(0, _text.Count);
        }
        
        _text[index].HideWord();
    }

    public bool AllHidden()
    {
        return _text.All(word => word.IsHidden());
    }

    
}