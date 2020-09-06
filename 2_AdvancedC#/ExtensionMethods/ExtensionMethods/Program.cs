using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortened = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() {2, 4, 6, 8 };
            Console.WriteLine( numbers.Max() ); //this is an extension method provided by System.Linq

            Console.WriteLine(shortened);
        }
    }
}
