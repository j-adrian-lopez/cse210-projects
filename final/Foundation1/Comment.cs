using System;

public class Comment 
{
    public string _personName;
    public string _commentText;

    public void DisplayComment()
    {
    Console.WriteLine($"{_personName}: {_commentText}");
    }
}