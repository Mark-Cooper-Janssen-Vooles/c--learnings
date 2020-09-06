using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //without linq
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //with linq Extension methods:
            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title); //can chain linq!
            //.Select is used for "projections" or "transformations".
            //the below code transforms a list of books into a list of strings.
            var cheapBooksTitleString = books.Select(b => b.Title);

            //more reader-friendly layout:
            var readerFriendly = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);


            foreach (var book in cheapBooks)
                Console.WriteLine($"{book.Title}, {book.Price}");

            //with LINQ query Operators: 
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            //============

            //other LINQ methods
            var single = books.Single(b => b.Title == "Book 3"); //if it can't find, it will crash. It wants one and only one object, if you're not sure better to use...
            Console.WriteLine(single.Title);

            var singleOrDefault = books.SingleOrDefault(b => b.Title == "hmm doesnt exist"); //returns null if it can't find, better to avoid exception crashing
            Console.WriteLine(singleOrDefault == null);

            var first = books.First(); //gives first book 
            var firstWithPredicate = books.First(b => b.Title == "Book 4"); //gives first book with that title, i.e. the one with price as $14.
            Console.WriteLine(firstWithPredicate.Price);

            var firstOrDefault = books.FirstOrDefault(b => b.Title == "Book 08089"); //if nothing matches the lambda condition, it returns null without throwing exception

            var last = books.Last();
            var lastOrDefault = books.LastOrDefault();

            var skip = books.Skip(2).Take(3); //this will skip the first 2, and take the next 3 to the new list.
            Console.WriteLine($"Skip:");
            foreach (var book in skip)
                Console.WriteLine(book.Title);

            var count = books.Count(); //will be 5

            var max = books.Max(b => b.Price); //what does max mean? in this case, highest price.
            Console.WriteLine(max); //this is the price itself.
            var min = books.Min(b => b.Price);
            Console.WriteLine(min);

            var sum = books.Sum(b => b.Price); //sum based on price of books
            Console.WriteLine(sum);

            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice); //float!
        }
    }
}
