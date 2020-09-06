using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mark Janssen ";
            Console.WriteLine( $"'{fullName.Trim()}'");
            Console.WriteLine($"{ fullName.ToUpper()}");

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            var newName = fullName.Replace("Mark", "Merk");
            Console.WriteLine(newName);

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine( price.ToString("C")); //every object in dotnet has a ToString method
        }
    }
}
