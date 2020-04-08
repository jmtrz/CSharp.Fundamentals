using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        /* 1 - Define a delegate - defines the signature of the method
         * 2 - Define an event based on that delegate
         * 3 - Raise the Event
         */

        //Long Way
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        // EventHandler
        // EventHandler<TEvetArgs>


        //Easy Way
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //Normal form
        //public event EventHandler VideoEncoding

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
        }
            
    }
}
