using System;

class Program
{
    static void Main(string[] args)
    {
        // Pass a scripture in one of the three constructor formats
        Random randomInt = new Random();
        int choice = randomInt.Next(0,4);
        Scripture scripture;
        if (choice == 1)
        {
            scripture = new Scripture("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, "+ 
                                                        "for I know that the Lord giveth no commandments unto the children of men, "+
                                                        "save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        } else if (choice == 2)
        {
            scripture = new Scripture("Exodus", 19, 5, 6, "Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me "+
                                                          "above all people: for all the earth is mine: \nAnd ye shall be unto me a kingdom of priests, and an holy nation. These "+
                                                          "are the words which thou shalt speak unto the children of Israel.");
        } else {
            scripture = new Scripture("Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields "+
                                                     "to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, "+
                                                     "and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to "+
                                                     "inflict upon him, even as a child doth submit to his father.");
        }

        // Reference reference = new Reference("Helaman 21:15-16");
        string reply;

        // Check if all words are hidden
        while(scripture.AllHidden() != true)
        {
            scripture.GetRendered();
            Console.WriteLine("\nPress Enter to continue. Type 'quit' to finish:");  
            reply = Console.ReadLine();
            if (reply.ToLower() == "quit")
            {
                break;
            }
            scripture.HideWords();
            // Render one last time before quitting
            scripture.GetRendered();
        };

        Console.WriteLine("End");
    }
}