using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Another Example
            //Worker work = new Worker();

            //Another Example
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); ///Publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
