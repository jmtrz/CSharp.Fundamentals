using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class TimeInfoEventArg
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public TimeInfoEventArg(int hour,int minute,int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
