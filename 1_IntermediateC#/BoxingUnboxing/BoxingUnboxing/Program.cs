using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //it takes a value of type object.. so its boxed (converted from value type to ref type)
            list.Add("hmm");
            list.Add(DateTime.Today); //dateTime is a struct, also value type, also boxed

            //var number = (int)list[1]; //this causes InvalidCastException, cos no type safety


            var anotherList = new List<int>(); //gives us type safety, no boxing will happen
            var names = new List<string>();
            

            // be aware if you're calling a class and it takes a type of "Object" .. be aware if you put a value type there, it will need to do boxing, and will have a perfomance penalty. Better to use a generic implementation of that class if it exists
        }
    }
}
