using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Worker :Employee
    {
        public double HourlyWage { get; set; }

        //name needs to go up to the parent class we use the :base to send up
        //the name to the parent calss
        public Worker(string name,double wage) :base(name)
        {
            HourlyWage = wage;
        }

        public override void TakeVacation()
        {
            vacationDays += 10;
        }

        public override string ToString()
        {
            return $"[Worker. Name:{Name} HourlyWage: {HourlyWage} Vacation: { vacationDays }]";
        }
    }
}
