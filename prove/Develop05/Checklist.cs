public class Checklist : Goal
{
private int _bonusPoints;
private int _timesAccomplished;
private int _timesToAccomplish;
public Checklist(string goalName, string goalDescription, int pointValue, int bonusPoints, int timesToAccomplish, int discountPoints): base(goalName, goalDescription, pointValue, discountPoints)
{
    _bonusPoints = bonusPoints;
    _timesToAccomplish = timesToAccomplish;
    _timesAccomplished = 0;
    SetGoalType(3);
    SetDiscountPoints(5);
}

public void SetBonus(int bonus)
{
    _bonusPoints = bonus;
}
public int GetBonus()
{
    return _bonusPoints;
}

public void SetTimes(int times)
{
    _timesToAccomplish = times;
}
public int GetTimes()
{
    return _timesToAccomplish;
}

public void SetTimesAccomplished(int times)
{
    _timesAccomplished = times;
}
public int GetTimesAccomplished()
{
    return _timesAccomplished;
}
public override int RecordEvent()
{
    return 0;
}

public override void DisplayGoalContent()
{
    Console.Write(GetGoal());
    Console.WriteLine($" ({GetDescription()}) -- Currently completed: {_timesAccomplished}/{_timesToAccomplish}");    
}

public override bool IsComplete()
{
    if(_timesAccomplished < _timesToAccomplish - 1)
    {
        _timesAccomplished += 1;
        return false;
    }
    else {
        _timesAccomplished += 1;
        Console.WriteLine($"You have completed this task! You get {_bonusPoints} bonus points!");
        SetPoints(GetPoints() + _bonusPoints);
        return true;
    }
}

public override string ConvertToString()
{
    return $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{GetTimesAccomplished()}|{GetTimes()}|{GetCompletion()}|{GetDiscountPoints()}";
}
}