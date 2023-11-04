using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate objects. Insert the messages and names each one will display for the activities 
        Menu menu = new Menu();

        int reply;
        
        Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing " + 
            "you in and out slowly. Clear your mind and focus on your breathing");
        
        Reflecting reflecting = new Reflecting("Reflecting", "This activity will reflect on times in your life when you have shown " + 
            "strength and resilience. This will help you recognize the power you have and how you can use it in other aspects " +
            "of your life");

        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things " +
            "as you can in a certain area.");

        Senses senses = new Senses("Senses", "This activity will help you increase your awareness of the moment you are living by asking you to pay attention " +
            "to each one of your senses.");
        
        do
        {
            menu.DisplayMenu();
            reply = int.Parse(Console.ReadLine());

            switch(reply){
                case 1:
                breathing.DisplayMessage();
                breathing.SetTimer();
                breathing.PauseAnimation();
                int time = breathing.GetTimer();
                breathing.RunBreathingActivity(time);
                breathing.DisplayEndMessage();
                break;

                case 2:
                reflecting.DisplayMessage();
                reflecting.SetTimer();
                reflecting.PauseAnimation();
                time = reflecting.GetTimer();
                reflecting.RunReflectingActivity(time);
                reflecting.DisplayEndMessage();
                break;

                case 3:
                listing.DisplayMessage();
                listing.SetTimer();
                listing.PauseAnimation();
                time = listing.GetTimer();
                listing.RunListingActivity(time);
                listing.DisplayEndMessage();
                break;

                case 4:
                senses.DisplayMessage();
                senses.SetTimer();
                senses.PauseAnimation();
                time = senses.GetTimer();
                senses.RunSensesActivity(time);
                senses.DisplayEndMessage();
                break;

                case 5:
                break;

                default:
                Console.WriteLine("Please choose a valid option.\n");
                break;
            } 
        } while(reply!=5);
    }
}