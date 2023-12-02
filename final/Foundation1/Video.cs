using System;

public class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int CountComments()
    {
        int counter = 0;
        foreach (Comment comment in _comments)
        {
            counter++;
        }
        return counter;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video: {_title}\nAuthor: {_author}\nLength: {_length} seconds");
        Console.WriteLine($"Number of comments: {CountComments()}\n");
        Console.WriteLine("Comments:");
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("---------------------------------------");
    }
}