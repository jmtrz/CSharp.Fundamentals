using System;

namespace EventsDemo
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("MessageService: Sending a text message " + args.Video.Title);
        }
    }
}
