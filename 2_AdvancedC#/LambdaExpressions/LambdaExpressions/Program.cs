using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    partial class Program
    {

        static void Main(string[] args)
        {
            // args => expression (args goes to expression)
            //number => number * number;
            // if we dont have any arguments, need to write it like this:
            // () => ..codehere..
            // x => ...
            //for multiple arguments:
            // (x, y, z) => ... 
            Func<int, int> squareLambda = number => number * number;

            Console.WriteLine(squareLambda(5));
            Console.WriteLine(SquareFunction(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(2));

            //more real life:

            var books = new BookRepository().GetBooks();
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //a predicate is a delegate that points to a method (in this case it takes type Book)
            //you can instead use a lambda and just insert it straight in: 
            var cheapBooks = books.FindAll(b => b.Price < 10); //common to use single letter in lambdas

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static int SquareFunction(int number)
        {
            return number * number;
        }
    }

}
