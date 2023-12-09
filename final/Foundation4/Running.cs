using System;

public class Running : Activity
{
    private double _distance;

    public Running(int length, double distance):base(length)
    {
        _distance = distance;
        SetName("Running");
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }

}