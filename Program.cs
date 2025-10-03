using StackOverflow_Post_Simulator;
using System;

namespace StackOverflowPostSimulator
{
    class program
    {
        //Main Method 
        static void Main(string[] args)
        {
            //Created a post from the postclass
            var post = new PostClass();
            post._title = "Test";
            post._description = "I have test tomorrow";
            post._dateCreated = DateTime.Now;
            
            //Adding of the list'
            Posts.Add(post);
             
            //Upvoting Logic
            if (post.Upvote())
                post._countValue++;
            Console.WriteLine("Post upvoted Successfully" +countValue);

            //Downvoting logic
            if(post.Downvote())
                post.Downvote();
            post._countValue--;
            Console.WriteLine("post downvoted successfully" + _countvalue);
    
        }
    }
}