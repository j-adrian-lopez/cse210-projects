using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    /* The first two constructors are the regular ones */
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

        public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Stretch: parse from single string
        public Reference(string reference)
    {
        /*The constructor gets the reference as a string
          and converts it to a Reference object*/
        string[] elements = reference.Split(" ");
        string numbers;

        // Check if the book starts with number to split it correctly.
        if (elements[0] == "1" || elements[0] == "2" ||
            elements[0] == "3" || elements[0] == "4")
        {
            // The book has a number and uses two indexes. 
            _book = $"{elements[0]} {elements[1]}";
            numbers = elements[2];
        }
        else
        {
            _book = elements[0];
            numbers = elements[1];
        }

        // Create array to split the numbers in reference
        string[] chapterAndVerse = numbers.Split(":");
        // Assign the chapter
        _chapter = int.Parse(chapterAndVerse[0]);
        
        // Assign verses depending on if they are multiple or not
        if(chapterAndVerse[1].Contains('-'))
        {
            string[] verses = chapterAndVerse[1].Split('-');
            _startVerse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
            _startVerse = int.Parse(chapterAndVerse[1]);
            _endVerse = 0;
        }
    }

    public string RenderRef()
    {   
        string reference;
        if(_endVerse != 0)
        {
            reference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        } else {
            reference = $"{_book} {_chapter}: {_startVerse}";
        }
        return reference;
    }

}