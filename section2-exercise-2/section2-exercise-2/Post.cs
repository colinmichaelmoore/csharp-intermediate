using System;

namespace section2_exercise_2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int Votes { get; set; }


        public int UpVote()
        {
            Votes++;
            return Votes;
        }
        public int DownVote()
        {
            Votes--;
            return Votes;
        }

        public int ShowVotes()
        {
            Console.WriteLine("This post has " + Votes + " votes.");
            return Votes;
        }


    }
}