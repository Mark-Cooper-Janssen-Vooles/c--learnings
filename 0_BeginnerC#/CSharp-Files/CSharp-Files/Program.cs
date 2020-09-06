using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // File and FileInfo
            //var path = @"c:\somefile.jpg";

            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //File.Delete(path);

            //if (File.Exists(path))
            //{
            //    // do somethin
            //}
            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...");
            //fileInfo.Delete();
            //if (fileInfo.Exists)
            //{
            //    //
            //}

            //Directory and DirectoryInfo
            Directory.CreateDirectory(@"C:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\mark.janssen-vooles\code\tutorials\c#-learnings\Iterations", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\mark.janssen-vooles\code\tutorials\c#-learnings\Iterations", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


            //PATH 
            var path = @"C:\Users\mark.janssen-vooles\code\tutorials\c#-learnings\Iterations";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            //better to do this:
            var extension2 = Path.GetExtension(path);
            var fileName2 = Path.GetFileName(path);
            var fileName3 = Path.GetFileNameWithoutExtension(path);
            var dirName = Path.GetDirectoryName(path);




        }
    }
}
