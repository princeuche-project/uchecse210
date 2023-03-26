using System;
using System.Collections.Generic;

namespace VideoComments
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video v1 = new Video("Introduction to C#", "Uchenna Godstime", 300);
            v1.Comments.Add(new Comment("Alice", "Great video!"));
            v1.Comments.Add(new Comment("Bob", "Thanks for the tutorial!"));
            v1.Comments.Add(new Comment("Charlie", "Very helpful, thanks!"));
            videos.Add(v1);

            Video v2 = new Video("C# OOP Concepts", "Uchenna Godstime", 450);
            v2.Comments.Add(new Comment("David", "Nice explanation of OOP!"));
            v2.Comments.Add(new Comment("Eva", "Very informative, thanks!"));
            videos.Add(v2);

            Video v3 = new Video("Debugging Tips in C#", "Uchenna Godstime", 200);
            v3.Comments.Add(new Comment("Frank", "This saved me a lot of time!"));
            videos.Add(v3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}