using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...");
            Console.WriteLine($"MessageService: {args.Video.Title}");
        }
    }
}
