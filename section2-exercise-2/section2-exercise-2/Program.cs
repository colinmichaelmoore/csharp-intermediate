using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section2_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "Hello World";
            post.Description = "How to write a CSharp Hello World application.";
            post.CreationDateTime = DateTime.Now;

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            post.ShowVotes();
        }
    }
}
