using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rachel = 20;
            int Robin = 26;
            int Stacey = 54;
            int Jesse = 60;

            //Suggested Practice
            if(Rachel > 18)
            {
                Console.WriteLine("Rachel can vote");
            }

            //Suggested Practice
            if(Rachel >= 21 && Robin >= 21)
            {
                Console.WriteLine("Rachel and Robin can Drink");
            }else if(Rachel > 21 || Robin >= 21)
            {
                Console.WriteLine("At lease one can drink");
            }

            ////It will work but poor programming practice
            //if(Rachel >= 21 && Robin >= 21)
            //    Console.WriteLine("Rachel and Robin can Drink"); 


        }
    }
}
