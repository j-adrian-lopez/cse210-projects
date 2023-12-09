using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int length, int laps):base(length)
    {
        _laps = laps;
        SetName("Swimming");
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetLength()) * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

}