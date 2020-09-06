using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            Console.WriteLine(dateTime);

            //to get current datetime:
            var now = DateTime.Now;
            Console.WriteLine(now);
            var today = DateTime.Today;
            Console.WriteLine(today);


            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            //DateTime objects in c# are immutable
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //convert to string 
            Console.WriteLine(now.ToLongDateString()); //only date
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString()); //only time
            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.ToString()); //displays both
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
