using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length: returns size of array
            Console.WriteLine(numbers.Length); //6

            //IndexOf()
            var index = Array.IndexOf(numbers, 9); //should return 2
            Console.WriteLine(index); //returns 2

            //Clear()
            Array.Clear(numbers, 0, 2); //sets first two numbers to 0

            Console.WriteLine("---------");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy()
            var numbers2 = new int[3];
            Array.Copy(numbers, numbers2, 3); //copies first 3 numbers from numbers to numbers2

            Console.WriteLine("----");
            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            //Sort()
            Array.Sort(numbers); //sorts from smallest to largest by default
            Console.WriteLine("----");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Reverse()
            Array.Reverse(numbers); //sorts by largest to smallest by default
            Console.WriteLine("Effect of reverse");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // if a method is accessible on the class itself, like Array.IndexOf(), that means its a static method. 

            // If you type "Array." it will give you all the static methods available on the array class.

            // if you type "numbers." it will give you all the methods that are not static, they are instance methods
        }
    }
}
