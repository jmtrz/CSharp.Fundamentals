using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Worker
    {
        public Worker()
        {
            Work();
        }
        public void Work()
        {
            Console.WriteLine("Open file Here");
            try
            {
                Console.WriteLine("Throwing Exception...");
                throw new System.Exception();
                Console.WriteLine("Closing File....");
            }
            catch (Exception)
            {
                Console.WriteLine("Handling Exception!");
            }
            finally
            {
                Console.WriteLine("Closing");
            }
        }

    }
}
