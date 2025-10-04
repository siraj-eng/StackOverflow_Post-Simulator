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

            // Add multiple answers
            while (true)
            {
                Console.Write("Enter an Answer (or type 'done' to finish): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "done")
                    break;

                post.AddAnswer(answer);
            }

            // Vote on Post
            Console.Write("Do you want to upvote or downvote the post (u/d): ");
            string postVote = Console.ReadLine();
            if (postVote.ToLower() == "u")
                post.Upvote();
            else
                post.Downvote();

            // Vote on a specific Answer
            if (post.Answers.Count > 0)
            {
                Console.WriteLine("\nHere are the answers:");
                for (int i = 0; i < post.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {post.Answers[i].AnswerText}");
                }

                Console.Write("Enter the number of the answer you want to vote on: ");
                int index;
                if (int.TryParse(Console.ReadLine(), out index))
                {
                    index -= 1; // zero-based index
                    if (index >= 0 && index < post.Answers.Count)
                    {
                        var chosenAnswer = post.Answers[index];

                        Console.Write("Do you want to upvote or downvote this answer (u/d): ");
                        string ansVote = Console.ReadLine();

                        if (ansVote.ToLower() == "u")
                            chosenAnswer.Answerupvote();
                        else
                            chosenAnswer.Answerdownvote();
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid answer number!");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid input!");
                }
            }

            // Final Display of Post + Answers
            Console.WriteLine("\n=== Final Post State ===");
            foreach (var p in posts)
            {
                p.Display();
            }

            Console.WriteLine("\n✅ Program finished.");
        }
    }
}
