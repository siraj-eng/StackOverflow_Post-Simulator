using StackOverflow_Post_Simulator;
using System;
using System.Collections.Generic;

namespace StackOverflowPostSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var posts = new List<PostClass>();

            // Create a post
            Console.Write("Enter the post Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the post Description: ");
            string description = Console.ReadLine();

            var post = new PostClass(title, description);
            posts.Add(post);

            // Answer the post
            Console.Write("Enter an Answer: ");
            string answer = Console.ReadLine();
            post.AddAnswer(answer);

            // Vote
            Console.Write("Do you want to upvote or downvote (u/d): ");
            string result = Console.ReadLine();

            if (result.ToLower() == "u")
                post.Upvote();
            else
                post.Downvote();

            // Display
            foreach (var p in posts)
            {
                p.Display();
            }
        }
    }
}
