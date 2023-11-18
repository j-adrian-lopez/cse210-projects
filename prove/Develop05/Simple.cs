public class Simple : Goal
{

public Simple(string goalName, string goalDescription, int pointValue): base(goalName, goalDescription, pointValue)
{
    SetGoalType(1);
    SetDiscountPoints(5);
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
    return true;
}

public override string ConvertToString()
{
    return $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}";
}

}