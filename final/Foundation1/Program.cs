using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        // Create video 1 and its comments
        Console.WriteLine("Program 1: Abstraction with YouTube Video\n");
        Video video1 = new Video();
        video1._author = "Rick Rhymes";
        video1._title = "The Tales of Rick";
        video1._length = 325;
        video1._comments = new List<Comment>();

        Comment comment1 = new Comment();
        comment1._personName = "Martin James";
        comment1._commentText = "I was waiting for this video to come out for ages";
        
        Comment comment2 = new Comment();
        comment2._personName = "moonchild";
        comment2._commentText = "Wow, what a great voice";
        
        Comment comment3 = new Comment();
        comment3._personName = "valsloeder";
        comment3._commentText = "This is my first time listening to this singer, his voice is fantastic!";
        
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        // Create video 2 and its comments
        Video video2 = new Video();
        video2._author = "GasPedal Reacts";
        video2._title = "Sonata Arctica - Tallulah Live (Reaction)";
        video2._length = 1231;
        video2._comments = new List<Comment>();

        Comment comment4 = new Comment();
        comment4._personName = "PatitoCM0";
        comment4._commentText = "This reaction gave me goosebumps. What an emotional ballad!";
        
        Comment comment5 = new Comment();
        comment5._personName = "corinna123";
        comment5._commentText = "I think you could have given it more time to develop your thoughts. I also noticed you paused every three seconds, which is extremely annoying";
        
        Comment comment6 = new Comment();
        comment6._personName = "zettckli";
        comment6._commentText = "I love this video, I've watched it a thousand plus times";
        
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        // Create video 3 and its comments
        Video video3 = new Video();
        video3._author = "HLeon";
        video3._title = "How I almost lost my job for a try...catch";
        video3._length = 1555;
        video3._comments = new List<Comment>();

        Comment comment7 = new Comment();
        comment7._personName = "fotegui01";
        comment7._commentText = "Finally, a programmer who knows what he's doing";
        
        Comment comment8 = new Comment();
        comment8._personName = "specter98";
        comment8._commentText = "These are so useful. Thank you for posting them";
        
        Comment comment9 = new Comment();
        comment9._personName = "Carl Jones";
        comment9._commentText = "A teacher of mine used to say we have to be careful with try... catch because of performance. Now it makes more sense";
        
        Comment comment10 = new Comment();
        comment10._personName = "barreda12";
        comment10._commentText = "What a painful experience";
         
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        
        // Display
        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();


    }
}