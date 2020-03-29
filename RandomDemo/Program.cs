using System;

namespace RandomDemo
{
    //use this class to generate random numbers
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for(var i = 0; i < 10; i++)
            {
                //Generate random numbers from 1 to 10
                Console.WriteLine(random.Next(1,10));
                //Generates random number
                //Console.WriteLine(random.Next());
                Console.Write((char)('a'+random.Next(0,26)));
                Console.WriteLine();
            }

            //introduce as ascii,for reference you may go to ascii-code.com
            Console.WriteLine((int)'a');

            //Standard
            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
