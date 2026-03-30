using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video v1 = new Video("Learning C# Basics", "John Dev", 600);
        v1.AddComment(new Comment("Ana", "This was really helpful!"));
        v1.AddComment(new Comment("Carlos", "I learned a lot from this video."));
        v1.AddComment(new Comment("Maria", "Great explanation!"));

        // VIDEO 2
        Video v2 = new Video("JavaScript for Beginners", "CodeMaster", 800);
        v2.AddComment(new Comment("Pedro", "Awesome content!"));
        v2.AddComment(new Comment("Lucas", "Loved the examples."));
        v2.AddComment(new Comment("Julia", "Very useful, thanks!"));

        // VIDEO 3
        Video v3 = new Video("HTML & CSS Crash Course", "WebPro", 500);
        v3.AddComment(new Comment("Rafa", "This saved my project!"));
        v3.AddComment(new Comment("Bianca", "Well explained."));
        v3.AddComment(new Comment("Gustavo", "Thanks a lot!"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($" - {c.Name}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}