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

        #region ExampleDiscussion
        //#1 Array example
        public void Sample()
        {
            /*
             If you notice under line 43 "numbers.length" and line 46 Array.IndexOf
             was called in the array class itself what is the difference.

             If a method is accessible in the class itself it means its a statci method.
             if its a static it is accessible in the class itself otherwise that members is 
             accessible via object
             */
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length:" + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers,9);
            Console.WriteLine("Index of 9:"+index);

            //Clear()
            Array.Clear(numbers,0, 2);
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers,another,3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

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
