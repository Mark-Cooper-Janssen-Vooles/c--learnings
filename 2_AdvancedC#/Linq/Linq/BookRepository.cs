using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "B book 1", Price = 1 },
                new Book() { Title = "A Book 2", Price = 2 },
                new Book() { Title = "Book 3", Price = 13 },
                new Book() { Title = "Book 4", Price = 14 },
                new Book() { Title = "Book 4", Price = 18 }

            };
        }
    }
}
