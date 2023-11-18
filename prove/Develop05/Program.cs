using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string name;
        string description;
        int points;
        int reply;
        int discount;

        ManageInterface newInterface = new ManageInterface();
        Menu menu = new Menu();

        do
        {
            newInterface.GetTotal();
            menu.DisplayMenu();
            reply = int.Parse(Console.ReadLine());

            switch(reply){

                case 1: //Create New Goal
                int type = menu.DisplayType();
                name = newInterface.InputName();
                description = newInterface.InputDescription();
                points = newInterface.InputPoints();
                discount = newInterface.InputDiscount();

                switch(type)
                {
                    case 1:
                    Simple simpleGoal = new Simple(name, description, points, discount);
                    newInterface.AddToList(simpleGoal);
                    break;

                    case 2:
                    Eternal eternalGoal = new Eternal(name, description, points, discount);
                    newInterface.AddToList(eternalGoal);
                    break;

                    case 3:
                    int times = newInterface.InputTimes();
                    int bonus = newInterface.InputBonus();
                    
                    Checklist checklistGoal = new Checklist(name, description, points, bonus, times, discount);
                    newInterface.AddToList(checklistGoal);
                    break;

                    default:
                    Console.WriteLine("Invalid Option");
                    break;
                    
                }
                break;

                case 2:
                newInterface.DisplayGoalList();
                break;

                case 3:
                newInterface.SaveToFile();
                Console.WriteLine("Your goals have been saved!\n");
                break;

                case 4:
                newInterface.LoadFromFile();
                Console.WriteLine("Your goals have been loaded!\n");
                break;

                case 5:
                newInterface.DisplayNames();
                newInterface.Register();
                break;

                case 6:
                newInterface.DisplayNames();
                newInterface.DeleteGoal();
                break;

                case 7:
                Console.WriteLine("Goodbye!\n");
                break;

                default:
                Console.WriteLine("Please choose a valid option.\n");
                break;
            } 
        } while(reply!=7);
    }
}