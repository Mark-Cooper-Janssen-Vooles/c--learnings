using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            Console.WriteLine(stopWatch.Duration);
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration);

            //---

            var post = new Post("A post title", "Some description can go here");
            Console.WriteLine(post.Title);
            Console.WriteLine(post.GetVotes());
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine(post.GetVotes());
        }
    }
}
