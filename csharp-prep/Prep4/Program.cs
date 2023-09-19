using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int smallNum = 99999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if(number != 0)
            {
                numbers.Add(number);
            }
            if (number < smallNum && number > 0)
            {
                smallNum = number;
            }
        } while (number != 0);
        int sumNumbers = numbers.Sum();
        float count = numbers.Count;
        double avg = sumNumbers / count;
        int highest = numbers.Max();
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is: {highest}");
        Console.WriteLine($"The smallest positive number is: {smallNum}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}