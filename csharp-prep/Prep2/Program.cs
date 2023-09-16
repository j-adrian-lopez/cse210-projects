using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the grade percentage and output letter grade
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        
        string grade;
        string sign;

        if (percentage >= 90)
        {
            grade = "A";
        }
        
        else if (percentage >= 80)
        {
            grade = "B";
        }
        
        else if (percentage >= 70)
        {
            grade = "C";
        }
        
        else if (percentage >= 60)
        {
            grade = "D";
        }
        
        else
        {
            grade = "F";
        }

        if (percentage < 60 || percentage >=93)
        {
            sign = "";
        }
        else if (percentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (percentage % 10 <=3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"You got an {grade}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else 
        {
            Console.WriteLine("You will pass the course next semester, don't give up!");
        }
    }
}