using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post_Simulator
{
    public class PostClass
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DateCreated { get; private set; }
        public int VoteCount { get; private set; }

        public PostClass( string title, string description) 
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
            VoteCount = 0;
        }

       

        //upvote method
        public void Upvote()
        {
            VoteCount++;
        }

        //downvote
        public void Downvote()
        {
            VoteCount--;
        }

        //display
        public void Display()
        {
            Console.WriteLine($"\n{Title}");
            Console.WriteLine($"\n{Description}");
            Console.WriteLine($"\n{DateCreated.ToShortTimeString}");
            Console.WriteLine($"\n{VoteCount}");
        }
        
    }
}
