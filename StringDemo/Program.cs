using System;

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
            Console.WriteLine(textWithVerbatim);

            string Name = "Lawrence";
            for(int i=0;i<Name.Length;i++)
            {
               
                Console.WriteLine(Name[i]);
            }
            
        }
    }
}
