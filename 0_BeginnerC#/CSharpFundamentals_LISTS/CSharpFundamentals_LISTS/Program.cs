using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_LISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 }); //whenever you see IEnumberable you can use an array or a list

            foreach(var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("IndexOf:");
            Console.WriteLine(numbers.IndexOf(1)); //returns the first one it finds 
            Console.WriteLine("LastIndexOf:");
            Console.WriteLine(numbers.LastIndexOf(1));

            Console.WriteLine("Count:");
            Console.WriteLine(numbers.Count);

            //Console.WriteLine("Remove: ");
            //Console.WriteLine(numbers.Remove(1)); //returns true if successful
            //foreach (var number in numbers)
            //    Console.WriteLine(number); //the first 1 has gone only

            Console.WriteLine("To remove all 1s");
            // cannot remove a number from inside a foreach block! Cannot modify collection inside a foreach loop!
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //        numbers.Remove(number);
            //}
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Clear: ");
            numbers.Clear();
            Console.WriteLine(numbers.Count);
        }
    }
}
