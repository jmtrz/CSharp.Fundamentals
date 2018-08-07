using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    class Worker
    {
        public Worker()
        {
            work();
        }

        public void work()
        {
            var listOfInt = new List<int>
            {
                2,7,3,13,5,18,6
            };
            var smallerNumbers = from num in listOfInt
                                 where num < 8
                                 select num;

            foreach(int number in smallerNumbers)
            {
                Console.WriteLine($"Value: {number}");
            }
            Console.WriteLine("\n----------------\n");
            var methods = from method in typeof(int).GetMethods()
                          orderby method.Name
                          group method by method.Name into groups
                          select new 
                          {
                              MethodName = groups.Key,
                              MethodOverloads = groups.Count()
                          };
            foreach(var item in methods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------------\n");

            var million = Enumerable.Range(0, 100000).Select(x =>
             {
                 Thread.Sleep(500);
                 return x * x;
             });

            foreach(var number in million)
            {
                Console.WriteLine($"{number} + ' ' ");
            }
        }
    }
}
