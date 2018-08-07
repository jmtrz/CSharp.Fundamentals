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
    }
}
