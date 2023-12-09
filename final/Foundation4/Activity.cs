using System;

public abstract class Activity
{
    private string _name;
    private string _date;
    private int _length;

    public Activity(int length)
    {
        _length = length;
        _date = DateTime.Now.ToString("dd MMM yyyy");
    }


    public void SetName(string name)
    {
        _name = name;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_length} min - Distance {Math.Round(CalculateDistance(), 2)} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph, Pace: {Math.Round(CalculatePace(), 2)} min per mile)");
    } 
}