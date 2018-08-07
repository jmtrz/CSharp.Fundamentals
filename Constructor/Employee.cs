using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        public int YearsOfService { get; set; }
        public int Office { get; set; }
        public Employee(int years,int office)
        {
            YearsOfService = years;
            Office = office;
        }
        //default constructor
        public Employee()
        {

        }
    }
}
