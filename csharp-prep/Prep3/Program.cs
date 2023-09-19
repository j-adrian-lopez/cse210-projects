using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!");
        string response;
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        do
        {
            // Create random integer instance 
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1, 100);
        
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            // Stretch 1 - Keep track of the number of guesses
            int countGuess = 1;
            while (guess != randomInt)
            {
                if (guess > randomInt)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    countGuess += 1;
                }
                else if (guess < randomInt)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    countGuess += 1;
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {countGuess} tries");

            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();

        } while (response == "yes" || response == "y");

        Console.WriteLine("Thank you for playing!");
    }
}