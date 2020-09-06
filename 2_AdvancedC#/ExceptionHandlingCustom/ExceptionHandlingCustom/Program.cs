using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCustom
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class YoutubeAPI
    {
        public List<string> GetVideos(string user)
        {
            try
            {
                throw new Exception("oops");
            }
            catch (Exception ex)
            {
                //a more meaningful custom exception
                throw new YoutubeException("Could not fetch videos from youtube", ex);
            }

            return new List<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    throw new NullReferenceException("oops");
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"In null ref exception {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"In generic exception {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("In finally block.");
            //}

            try
            {
                var api = new YoutubeAPI();
                api.GetVideos("hmm");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
