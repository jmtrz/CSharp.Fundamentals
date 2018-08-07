using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class DigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;

        }

        public void NewTime(object o,TimeInfoEventArg e)
        {
            Console.WriteLine($"Current time: {e.Hour.ToString()} {e.Minute.ToString()}{e.Second.ToString()}");
        }
    }
}
