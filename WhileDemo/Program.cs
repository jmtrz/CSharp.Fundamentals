using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myLittleHorses = 0;
            while(myLittleHorses < 10)
            {
                Console.WriteLine($"myLittleHorses ={myLittleHorses}");
                myLittleHorses++;
            }

            //we will run atleast once whether the test passes or not
            do
            {
                Console.WriteLine($"myLittleHorses ={myLittleHorses}");
                myLittleHorses++;
            } while (myLittleHorses < 0);
        }

        private void While()
        {
            //for (var i = 1;i <=10; i++)
            //{
            //    if(i%2 == 0)
            //        Console.WriteLine(i);
            //}

            var i = 0;
            while(i <= 10)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }
        }

        private void NameGen()
        {
            while(true)
            {
                Console.WriteLine("Type your name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo:" + input);
                    continue; //it will continue in the beginning of the loop
                }

                break;
               
            }
        }
    }
}
