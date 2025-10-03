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

            //Added post 1
            var post1 = new PostClass("Test", "I have a test tomorrow");
            posts.Add(post1);

            var post2 = new PostClass("Error", "Make the error grow");
            posts.Add(post2);


            //display
            for (int i = 0; i < posts.Count; i++)
            {
                Console.WriteLine("Post Display Loading.....!");
                Console.WriteLine("Post Display Loaded");
            }
        }
    }
}