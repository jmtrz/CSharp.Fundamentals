using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
        }
        
        //Working with Generic List
        public void ListSample()
        {
            var numbers = new List<int>() { 1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5,6,7 });

            foreach (var item in numbers)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine( "index of 1" + numbers.IndexOf(1) );
            Console.WriteLine("Last index of 1" + numbers.LastIndexOf(1));

            Console.WriteLine("Count:" + numbers.Count);

            numbers.Remove(1);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var item in numbers)
                Console.WriteLine(item);

            numbers.Clear();
            Console.WriteLine("Count:" + numbers.Count);
        }
    }
}
