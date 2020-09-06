using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING: 
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width); //shows 100

            //StreamReader reader = new StreamReader(new MemoryStream()); //this will automatically be upcast

            //ArrayList list = new ArrayList(); //no type safety
            //list.Add(8);
            //list.Add("hmm");
            //list.Add(new Text());

            //var anotherList = new List<int>();

            // DOWNCASTING:
            Shape shape = new Text();
            Text text = (Text)shape;
        }
    }
}
