using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1. define a delegate (determines the signature of the method in the subscriber)
        //2. Define an event based on that delegate
        //3. Raise the event

        //this is the convention in .net: first argument is an object of source, second argument is what you want to send to the event 
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);// step 1.

        //public event VideoEncodedEventHandler VideoEncoded; // step 2. past tense refers to that something has happened or finished

        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); //assume this method will notify all subscribers
        }

        //.net convention is that event publisher methods should be protected, virtual and void. Should start with "On"
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) //i.e. there are subscribers
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video }); // EventArgs.Empty when you don't want to send any data
            }
        }
    }
}
