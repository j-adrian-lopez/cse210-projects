using System.IO;
using System.Linq;
public class ManageInterface
{
    private int _totalPoints;
    public List<Goal> _goalList;

public ManageInterface()
{
    _totalPoints = 0;
    _goalList = new List<Goal>();
}

public void DisplayGoalList()
{
    int index = 1;
    Console.WriteLine("These are your goals: \n");
    foreach(Goal goal in _goalList)
    {
        Console.Write($"{index}. ");
        if (goal.GetCompletion() == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        goal.DisplayGoalContent();
        index++;
    }
    Console.WriteLine("");
}

public void DisplayNames()
{
    int index = 1;
    foreach(Goal goal in _goalList)
    {
        Console.Write($"{index}. ");
        Console.WriteLine(goal.GetGoal());
        index++;
    }
    Console.WriteLine("");
}

public void Register()
{
    Console.Write("Which goal did you accomplish? ");
    int goalNum = int.Parse(Console.ReadLine());
    if(goalNum > _goalList.Count()) {
        Console.WriteLine("Please select a valid goal.");
    }
    else
    {
        Goal goal = _goalList[goalNum - 1];
        if(goal.GetCompletion() == false){
        goal.SetCompletion(goal.IsComplete());
        int earnedPoints = goal.GetPoints();
        SumPoint(earnedPoints);
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!\nYou now have {_totalPoints} points.");
        }
        else
        {
            Console.WriteLine("This is a completed goal");
        }
    }
}

public void SaveToFile()
{
string fileName = "goals.txt";

using (StreamWriter outputFile = new StreamWriter(fileName))
{
    outputFile.WriteLine(_totalPoints);

    foreach(Goal goal in _goalList)
    {
        outputFile.WriteLine(goal.ConvertToString());
    }
}
}
public void LoadFromFile() {
        Console.Write("Please enter the name of the file: ");
        string fileName = Console.ReadLine() + ".txt";
        
        List<Goal> goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int firstLine = int.Parse(File.ReadLines(fileName).First());
        _totalPoints = firstLine;

        foreach (string line in lines)
        {
        string[] parts = line.Split("|");
        int type = int.Parse(parts[0]);

        switch(type)
        {
            case 1:
            Simple simpleGoal = new Simple(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]));
            simpleGoal.SetCompletion(bool.Parse(parts[4]));
            goals.Add(simpleGoal);
            break;

            case 2:
            Eternal eternalGoal = new Eternal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]));
            goals.Add(eternalGoal);
            break;

            case 3:
            Checklist checklistGoal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]), int.Parse(parts[8]));
            checklistGoal.SetCompletion(bool.Parse(parts[7]));
            checklistGoal.SetTimesAccomplished(int.Parse(parts[5]));
            goals.Add(checklistGoal);
            break;
        }

        }
        _goalList = goals;
    }
public void SumPoint(int points)
{
    _totalPoints += points;
}

public void Discount(int points)
{
    _totalPoints -= points;
}

public string InputName()
{
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    return name;
}

public string InputDescription()
{
    Console.Write("What is a short description of your goal? ");
    string description = Console.ReadLine();
    return description;
}

public int InputPoints()
{
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());
    return points;
}

public int InputTimes()
{
    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
    int times = int.Parse(Console.ReadLine());
    return times;
}

public int InputBonus()
{
    Console.Write("What is the bonus for accomplishing it that many times? ");
    int bonus = int.Parse(Console.ReadLine());
    return bonus;
}

public int InputDiscount()
{
    Console.Write("How many points should be discounted if the goal is deleted before completion? ");
    int discount = int.Parse(Console.ReadLine());
    return discount;
}

public void AddToList(Goal goal)
{
    _goalList.Add(goal);
}

public void GetTotal()
{

    Console.WriteLine($"\nYou have {_totalPoints} points.\n");
}

public void DeleteGoal()
{
    
    Console.Write("Which goal would you like to delete? ");
    int goalNum = int.Parse(Console.ReadLine());
    if(goalNum > _goalList.Count()) {
        Console.WriteLine("Please select a valid goal.");
    }
    else if(_goalList[goalNum - 1].GetCompletion() == true)
    {
        _goalList.RemoveAt(goalNum - 1);
        Console.WriteLine("Your completed goal has been deleted");
    }

    else
    {
        Goal goal = _goalList[goalNum - 1];
        int pointsToDiscount = goal.GetDiscountPoints();
        Console.WriteLine($"This goal has not been completed. If you delete it, you get a discount of {pointsToDiscount} points");
        Console.Write("Would you like to proceed with the deletion? (y/n) ");
        string response = Console.ReadLine();
        while(response.ToLower() != "y" || response.ToLower() != "yes")
        {
            Console.WriteLine("Deletion Canceled.");
            break;
        }

        _goalList.RemoveAt(goalNum - 1);
        Console.WriteLine("Deletion Complete.");
        Discount(pointsToDiscount);
        Console.WriteLine($"{pointsToDiscount} points have been discounted from your total points.");
        Console.WriteLine($"You now have {_totalPoints} points.");

    }
    }

}