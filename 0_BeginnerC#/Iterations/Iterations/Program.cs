using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (var i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var name = "John Smith";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var letter in name)
            //{
            //    Console.WriteLine(letter);
            //}

            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //    i++;
            //}

            // while loops are better if you dont know how many times it will run.

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine($"@Echo: {input}");
            //        continue;
            //    }

            //    break;
            //}

            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    var randomNum = random.Next(97, 122);
            //    Console.WriteLine(randomNum);
            //    Console.WriteLine((char)randomNum); //ascii
            //}

            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                var asciiMin = 97;
                var asciiMax = 122;
                var randomNum = random.Next(asciiMin, asciiMax);
                buffer[i] = (char)randomNum;
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
