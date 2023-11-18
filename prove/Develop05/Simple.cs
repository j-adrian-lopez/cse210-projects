public class Simple : Goal
{

public Simple(string goalName, string goalDescription, int pointValue, int discountPoints): base(goalName, goalDescription, pointValue, discountPoints)
{
    SetGoalType(1);
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
    return $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}|{GetDiscountPoints()}";
}

}