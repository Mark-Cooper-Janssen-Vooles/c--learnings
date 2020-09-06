using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine("it worked");
            else
                Console.WriteLine("didnt work");

        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 10));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);

                point.Move(100, 200);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured, in catch block");
            }
        }
    }
}
