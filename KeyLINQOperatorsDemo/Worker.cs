using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLINQOperatorsDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var listOfInt = new List<int>{ 2,7,3,13,5,18,16 };

            var listOfInt2 = new List<int>();

            bool hasAny = listOfInt.Any();
            bool hasAny2 = listOfInt2.Any();
            bool hasAny3 = listOfInt.Any(x => x == 3);
            bool has12 = listOfInt.Any(x => x==12);

            Console.WriteLine("Any...");
            Console.WriteLine($"listOfInt has members? {hasAny}");
            Console.WriteLine($"listOfInt2 has members? {hasAny2}");
            Console.WriteLine($"listOfInt3 has members? {hasAny3}");

            Console.WriteLine($"\n-------------------\n");

            var take5 = listOfInt.Take(5).Select(x => x * 10);

            Console.WriteLine("Brubeck...");

            foreach(int value in take5)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\n--------------------\n");

            var multipleValueList = new List<int>
            { 2,7,3,7,3,2,13,5,13,18,16 };

            var outputDistinct = multipleValueList.Distinct().Select(x => x * 9);
            Console.WriteLine("Distinct");

            foreach(int value in outputDistinct)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("ZIP");
            var codes = new List<String> { "AL","AK","AZ","AR","CA","CO","CT" };
            var states = new List<string> {"Alabama","Alaska","Arizona","Arkanas","California","Colorado","Connecticut" };

            var codeWithStates = codes.Zip(states,(code,state)=>$"{code}:{state}");

            foreach(var item in codeWithStates)
            {
                Console.WriteLine(item);
            }

        }
    }
}
