using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Document : IStorable, ISpeak
    {
        public void Reformat()
        {
            Console.WriteLine("Reformating the document");
        }
        public double DurationOfSpeech
        {
            get { return 42; }

        }

        public void Read(string fileName)
        {
            Console.WriteLine($"Reading from {fileName}");
        }

        public void Speak()
        {
            Console.WriteLine("Speaking.....");
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"Writing to {fileName}");
        }

    }
}
