using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
    List<Event> eventList = new List<Event>();

    Lecture event1 = new Lecture("Prof. Hans Richt",
                                 100,
                                 "Social Media After Covid-19",
                                 "An analysis of what is the new normal in social media after the pandemic, and how we navigate through the new internet culture",
                                 "November 20, 2024",
                                 "16:30",
                                 "Walnut St. 25",
                                 "Pennsylvania",
                                 "PA"
                                 );

    Reception event2 = new Reception("registerhere@registration.com",
                                 "Nelson & Nancy Wedding",
                                 "Nelson and Nancy have decided to unite their lives for all eternity, and they want to share the joy with you",
                                 "June 15, 2024",
                                 "18:00",
                                 "Oak St. 122",
                                 "Chicago",
                                 "IL"
                                 );

    Outdoor event3 = new Outdoor("Cloudy, 77°F",
                                 "Great Company Picnic",
                                 "Come with your family to share a picnic and talk about anything",
                                 "January 16, 2024",
                                 "09:00",
                                 "Maple St. 262",
                                 "Amarillo",
                                 "TX"
                                 );

        eventList.Add(event1);
        eventList.Add(event2);
        eventList.Add(event3);

        Console.Clear();
        Console.WriteLine("Program 3: Inheritance with Event Planning\n");
        int counter = 1;
        foreach(Event newEvent in eventList)
        {

            Console.WriteLine($"Event {counter}");
            Console.WriteLine(newEvent.DisplayStandard());
            Console.WriteLine(newEvent.DisplayFullDetails());
            Console.WriteLine(newEvent.DisplayShortDescription());
            counter++;
        }

    }


}