using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("123", filterHandler);
        }

        //to add a new filter, while not changing the PhotoProcessor / PhotoFilters classes:
        static void RemoveRedEyeFilter(Photo photo) //it must have the same signature as the delegate
        {
            System.Console.WriteLine("Apply remove red eye");
        }
    }
}
