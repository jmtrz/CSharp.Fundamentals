using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            //Another set of tutorial
            int[] numbers = new int[3];
                //var numbers = new int[3];

            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "jack", "john", "Mary" };
        }

        public void ArrayDemo()
        {
            var numbers = new[] {3,7,9,2,14,6 };

            //LEngth
            Console.WriteLine("Legth: " + numbers.Length);

            //IndexOf - has method overloading
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:");

            //Clear()
            Array.Clear(numbers,0,2);
            Console.WriteLine("effect of Clear()");
            foreach (var item in numbers)
                Console.WriteLine(item);

            //copy()
            int[] another = new int[3];
            Console.WriteLine("effect of Copy()");
            Array.Copy(numbers,another,3);
            foreach (var item in another)
                Console.WriteLine(item);

            //Sort()
            Console.WriteLine("effect of Sort()");
            Array.Sort(another);
            foreach (var item in numbers)        
                Console.WriteLine();

            //Reverse()
            Console.WriteLine("effect of reverse()");
            Array.Reverse(numbers);
            foreach (var item in numbers)
                Console.WriteLine(item);
        }
    }
}
