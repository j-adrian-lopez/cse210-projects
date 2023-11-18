public abstract class Goal
{
private bool _isComplete;
private string _goalName;
private string _goalDescription;
private int _pointValue;
private int _goalType; // 1 for Simple, 2 for Eternal, 3 for Checklist
private int _discountPoints;

public Goal(string goalName, string goalDescription, int pointValue)
{
    _goalName = goalName;
    _goalDescription = goalDescription;
    _pointValue = pointValue;
    _isComplete = false;
}

public void SetGoalType(int goalType)
{
    _goalType = goalType;
}

public int GetGoalType()
{
    return _goalType;
}

public void SetGoal(string goal)
{
    _goalName = goal;
}

public string GetGoal()
{
    return _goalName;
}

public void DisplayGoalType()
{
    Console.WriteLine(_goalType);
}

public void SetDescription(string description)
{
    _goalDescription = description;
}

public string GetDescription()
{
    return _goalDescription;
}

public void SetPoints(int points)
{
    _pointValue = points;
}

public int GetPoints()
{
    return _pointValue;
}

public void SetDiscountPoints(int discountPoints)
{
    _discountPoints = discountPoints;
}

public int GetDiscountPoints()
{
    return _discountPoints;
}

public bool GetCompletion()
{
    return _isComplete;
}

public void SetCompletion(bool completed)
{
    _isComplete = completed;
}


public abstract int RecordEvent();

public abstract void DisplayGoalContent();

public abstract string ConvertToString();

public abstract bool IsComplete();

}