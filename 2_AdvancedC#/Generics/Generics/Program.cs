using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new GenericDictonary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>();
            System.Console.WriteLine(number.HasValue);
            System.Console.WriteLine(number.GetValueOrDefault());
        }
    }
}
