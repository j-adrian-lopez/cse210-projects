using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, double speed):base(length)
    {
        _speed = speed;
        SetName("Cycling");
    }

    public override double CalculateDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

}