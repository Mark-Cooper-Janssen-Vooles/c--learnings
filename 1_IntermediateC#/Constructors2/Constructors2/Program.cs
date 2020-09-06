using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("hmm"); //when you create an object, the constructor of the base class is always executed first.
        }
    }
}
