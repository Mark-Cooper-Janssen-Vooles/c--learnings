using System;

namespace Events
{
    public class MailService
    {
        //sends email once video is encoded
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
            Console.WriteLine($"MailService: {e.Video.Title}");
        }
    }
}
