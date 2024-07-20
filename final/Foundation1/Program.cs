using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Learn C# in One Hour", "CodeAcademy", 3600);
        Video video3 = new Video("Top 10 Travel Destinations", "TravelXP", 1200);

        // Add comments to videos
        video1.AddComment(new Comment("Steve", "Great recipe!"));
        video1.AddComment(new Comment("Blessing", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charles", "Yummy!"));

        video2.AddComment(new Comment("Dave", "Very informative."));
        video2.AddComment(new Comment("Evelyn", "I learned a lot."));
        video2.AddComment(new Comment("Frank", "Excellent tutorial."));

        video3.AddComment(new Comment("Grace", "I want to go there!"));
        video3.AddComment(new Comment("Hannah", "Beautiful places."));
        video3.AddComment(new Comment("Ifiok", "Thanks for the tips."));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
