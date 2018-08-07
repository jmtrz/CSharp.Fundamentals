using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Manager : Employee
    {
        public bool CompanyCar { get; set; }

        public Manager(string name, bool hasCar) :base(name)
        {
            CompanyCar = hasCar;
        }

        public override void TakeVacation()
        {
            vacationDays += 15;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void DriveCar()
        {
            if(CompanyCar)
            {
                Console.WriteLine("Driving the car");
            }
        }
    }
}
