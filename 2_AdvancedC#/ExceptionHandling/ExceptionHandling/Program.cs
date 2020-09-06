using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var streamReader = new StreamReader(@"c:\file.zip");
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0); //this will cause the program to crash 
                //var content = streamReader.ReadToEnd();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                var link = ex.HelpLink != null ? ex.HelpLink : "no link";

                Console.WriteLine($"Sorry an error occured: {ex.Message} {link}"); //this means if an error is thrown, the app won't crash

                //throw; //you can still throw a custom error here to crash it
            }
            finally
            {
                //we can use the finally block to call the dispose method 
                // the finally block will always be executed
                //streamReader.Dispose();
                Console.WriteLine("finally block");
            }
        }
    }
}
