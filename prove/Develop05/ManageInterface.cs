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
            Simple simpleGoal = new Simple(parts[1], parts[2], int.Parse(parts[3]));
            simpleGoal.SetCompletion(bool.Parse(parts[4]));
            goals.Add(simpleGoal);
            break;

            case 2:
            Eternal eternalGoal = new Eternal(parts[1], parts[2], int.Parse(parts[3]));
            goals.Add(eternalGoal);
            break;

            case 3:
            Checklist checklistGoal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
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

public void AddToList(Goal goal)
{
    _goalList.Add(goal);
}

public void GetTotal()
{

    Console.WriteLine($"\nYou have {_totalPoints} points.\n");
}

}