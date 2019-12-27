using System;
using System.Collections.Generic;
using System.Text;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            /*string and String is different
             * you can only use String upon calling using System
             * Int32 and int is the same, the difference is the source
             */
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;

            var myFulleName = string.Format("{0} {1}",firstName,lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",",names);

            Console.WriteLine(formattedNames);

            var text = "Hi John\nlook into the following paths\nc:\\folder\\folder1\\folder2\nc:\\folder3\\folde4";
            var textWithVerbatim = @"Hi John
                                    look into the following paths
                                    c:\\folder\\folder1\\folder2
                                    c:\folder3\folde4";
            Console.WriteLine(text);
        }

        public void StringSample()
        {
            var summary = summarizeText("This is going to be really really really really really long text");
            Console.WriteLine(summary);
        }

        public string summarizeText(string sentence, int maxLength = 20)
        {

            if (sentence.Length < maxLength)
                return sentence;
            
            var words = sentence.Split(' ');
            var totalcharacters = 0;
            var summaryWords = new List<string>();

            foreach (var item in words)
            {
                summaryWords.Add(item);

                totalcharacters += words.Length + 1;
                if (totalcharacters > maxLength)
                    break;
            }
            
            return String.Join(" ", summaryWords) + ".....";
        }

        //No Search only Manipulation
        public void StringBuilderSample()
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-',10)
                .AppendLine()         
                .Append("header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-','+')
                .Remove(0,10)
                .Insert(0, 10)        
                .Insert(0, new string('-',10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
