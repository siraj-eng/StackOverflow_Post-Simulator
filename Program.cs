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

            var post = new PostClass("Test", "I have a test tomorrow");
            posts.Add(post);
            
            //upvote
            post.Upvote();
            Console.WriteLine("Post upvoted successfully. Votes: " + post.VoteCount);

            //Downvote
            post.Downvote();
            Console.WriteLine("Post downvoted successfully. Votes " +post.VoteCount);   
        }
    }
}