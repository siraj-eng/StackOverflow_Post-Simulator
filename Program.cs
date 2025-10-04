using StackOverflow_Post_Simulator;
using System;

namespace StackOverflowPostSimulator
{
    class program
    {
        //Main Method 
        static void Main(string[] args)
        {
            var posts = new List<PostClass>();

            //Get post title from user
            Console.Write("Enter the post Title");
            string title1 = Console.ReadLine();

            //Get the post Description
            Console.WriteLine("Enter the post Description");
            string description1 = Console.ReadLine();

            var post1 = new PostClass(title1, description1);
            posts.Add(post1);

            Console.Write("Answer the post Question");
            string Answer = Console.ReadLine();

            var post2 = new PostClass(Answer); //Object initialization -- feature
            post2.AddAnswer();
            posts.Add(post2);

            Console.Write("Do you want to upvote or downvote (u/d)");
            string result = Console.ReadLine();

            if (result.ToLower() == "u")
            {
                post1.Upvote();
                Console.WriteLine("Post1 upvoted" + post1.VoteCount);

            }
            else
            {
                post1.Downvote();
                Console.WriteLine("Post1 Downvoted" + post1.VoteCount);
            }

            //Display
            for (int i = 0; i < posts.Count; i++) 
            {
                var p = posts[i];
                p.Display();
            }
        }
    }
}