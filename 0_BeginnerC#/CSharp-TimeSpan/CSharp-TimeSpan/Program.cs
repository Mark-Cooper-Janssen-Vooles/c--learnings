using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating timeSpan objects:

            //timespan is a length of time! 
            var timeSpan = new TimeSpan(1, 2, 3);

            //duration 1hr
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan1 = TimeSpan.FromHours(1); //more readable

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; //this creates a timespan

            Console.WriteLine(duration);

            //Timespan Properties:
            Console.WriteLine(timeSpan.TotalMinutes); //62.05
            Console.WriteLine(timeSpan.Minutes); //2

            //Add (similar to dateTime, it is immutable. but provides add and subtract (returns new timespan)
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //conversion to and from string 
            timeSpan.ToString();
            TimeSpan.Parse("01:02:03"); //this returns a timespan object
        }
    }
}
