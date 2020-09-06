using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mark";
            //obj.GetHashCode();

            //this is called "reflection"
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //this is using dynamic ... we expect at run-time to have the optimise method, but we don't have it at compile-time
            //dynamic excelObject = "mark";
            //excelObject.Optimize();

            //============

            dynamic name = "Mark";
            name = 10;

            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //var is now "dynamic"

            int i = 5;
            dynamic d = i;
            long l = d; //at runtime d will be an integer, and we can put an integer into a long type (implicit cast)
        }
    }
}
