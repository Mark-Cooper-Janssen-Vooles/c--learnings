using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.autumn;

            switch (season)
            {
                case Season.autumn:
                case Season.summer:
                    Console.WriteLine("We've got a promotion");
                    break;
                default:
                    Console.WriteLine("Shit weather");
                    break;
            }
        }
    }
}
