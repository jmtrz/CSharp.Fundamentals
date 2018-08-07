using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Worker("Bob", 35.00);
            Employee joe = new Manager("Joe", true);
            Employee sally = new Worker("Sally",27.50);

            List<Employee> employee = new List<Employee>()
            {
                joe,
                bob,
                sally
            };

            for(int i=0;i< employee.Count;i++)
            {

                employee[i].TakeVacation();
                Console.WriteLine(employee[i]);
            }
        }
    }
}
