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
        public List<AnswerClass> Answers { get; private set; } //List to store the answer

        public PostClass( string title, string description) 
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
            VoteCount = 0;
            Answers = new List<AnswerClass>();

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

        //Add Answer
        public void AddAnswer()
        {
            Answers.Add(new AnswerClass(answerText));    
        }

        //display
        public void Display()
        {  

            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"DateCreated {DateCreated.ToShortTimeString()}");
            Console.WriteLine($"VoteCount {VoteCount}");
            Console.WriteLine($"Answers {Answers.Count}");

            foreach (var ans in Answers) 
            {
                ans.Display();  
            }
        }
        
    }

    public class AnswerClass
    {
        public string AnswerText { get; private set; }
        public DateTime DateCreated { get; private set; }

        public AnswerClass() 
        {
            AnswerText = answerText;
            DateCreated = DateTime.Now;

        }

        public void Display()
        {
            Console.WriteLine($"   ↳ {AnswerText} (at {DateCreated.ToShortTimeString()})");

        }
    }
}
