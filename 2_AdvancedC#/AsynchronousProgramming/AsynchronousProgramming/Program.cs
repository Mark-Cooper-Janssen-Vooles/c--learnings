using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class AsyncStuff
    {
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        public async Task DownloadHtmlAsync(string url) //the convention is to use Async on the end of the name
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); //returns a Task of type string
            //typically when we download an async task, we need to put await in front 


            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
