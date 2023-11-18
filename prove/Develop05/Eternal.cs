public class Eternal : Goal
{
private DateTime _completionDate;
public Eternal(string goalName, string goalDescription, int pointValue, int discountPoints): base(goalName, goalDescription, pointValue, discountPoints)
{
    SetGoalType(2);
}

public void SetCompletionDate(DateTime date)
{
    _completionDate = date;
}

public DateTime GetCompletionDate()
{
    return _completionDate;
}
public override int RecordEvent()
{
    return 0;
}

public override void DisplayGoalContent()
{
    Console.Write(GetGoal());
    Console.WriteLine($" ({GetDescription()})");    
}

public override bool IsComplete()
{
    return false;
}

public override string ConvertToString()
{
    return $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}|{GetDiscountPoints()}";
}
}