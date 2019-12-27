using System;
using System.Collections.Generic;

namespace DebuggingDemo
{
    class Program
    {
        //what is we only have 2 values entered by the user
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1 , 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach(var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            //if (list == null)
            //    throw new ArgumentNullException("list");

            //if (count > list.Count || count <= 0 )
            //    throw new ArgumentOutOfRangeException("count","Count cannot be greater than the number of elements in the list");
            
            //var buffer = new List<int>(list);
            var smallests = new List<int>();

            while(smallests.Count < count)
            {
                var min = GetSmallest(list);//buffer
                smallests.Add(min);
                list.Remove(min);
                //buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}
