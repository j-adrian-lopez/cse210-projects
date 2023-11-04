using System;

public class Menu
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Start senses activity\n5. Quit");
        Console.Write("\nSelect a choice from the menu: ");
    }
}