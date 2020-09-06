using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = null; //this won't work
            Nullable<DateTime> date = null; //this will - value type or a null
            DateTime? date2 = null; //this is the short hand version

            //members of a nullable type:
            Console.WriteLine($"get value or default: {date2.GetValueOrDefault()}"); //returns a value if the object has been initialised, or the default for that value type
            Console.WriteLine($"hasValue: {date2.HasValue}"); //returns true if value, null if false
            //Console.WriteLine($"value: {date2.Value}"); //throws exception if null. better to use "GetValueOrDefault"! 

            //======

            DateTime? date3 = new DateTime(2014, 1, 1);
            DateTime date4 = date3.GetValueOrDefault();
            DateTime? date5 = date4;


            //===

            DateTime? date6 = null;
            DateTime date7;

            if (date6 != null)
                date7 = date6.GetValueOrDefault();
            else
                date7 = DateTime.Today;

            Console.WriteLine(date7);

            //==
            //above written shorter like:
            DateTime date8 = date6 ?? DateTime.Today; //"null coalescing operator"
            //similar to tertiary operator...
            DateTime date9 = (date6 != null) ? date.GetValueOrDefault() : DateTime.Today;
        }
    }
}
