using System;
using System.Collections.Generic;

namespace ProceduralProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            var reversed = ReverseName(name);
            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - 1] = name[i - 1];
            //return new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - 1] = name[i - 1];
            return new string(array);            
        }

        public void Example2()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exit)");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
          
            //var uniques = new List<int>();
            //foreach (var item in uniques)
            //{
            //    if (!uniques.Contains(item))
            //        uniques.Add(item);
            //}

            Console.WriteLine("unique numbers:");
            foreach (var item in GetUniqueNumbers(numbers))
                Console.WriteLine(item);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var item in uniques)
            {
                if (!uniques.Contains(item))
                    uniques.Add(item);
            }

            return uniques;
        }
    }
}
