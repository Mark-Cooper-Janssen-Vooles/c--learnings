using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new System.DateTime(1991, 11, 23));
            //person.BirthDate = new System.DateTime(1991, 11, 23);
            System.Console.WriteLine(person.Age);
        }
    }
}
