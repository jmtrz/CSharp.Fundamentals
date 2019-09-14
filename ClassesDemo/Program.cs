using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee tony = new Employee();
    //        tony.Income = 15000;
    //        tony.YearsOfService = 8;
    //        tony.SetRating(Employee.Rating.excellent);
    //        tony.CalculateRaise();
    //    }
    //}

    //public class Employee
    //{
    //    public enum Rating
    //    {
    //        poor,
    //        good,
    //        excellent
    //    }

    //    //private member variable
    //    private Rating rating;

    //    //create a property
    //    public double Income { get; set; }
    //    public int YearsOfService { get; set; }

    //    //Method witin our class
    //    public void SetRating(Rating rating)
    //    {
    //        this.rating = rating;
    //    }

    //    public void CalculateRaise()
    //    {
    //        double baseRaise = Income * 0.5;
    //        double bonus = YearsOfService * 1000;
    //        Income += baseRaise = bonus;

    //        switch(rating)
    //        {
    //            case Rating.poor:
    //                Income -= YearsOfService * 2000;
    //                break;
    //            case Rating.good:
    //                break;
    //            case Rating.excellent:
    //                Income += YearsOfService * 500;
    //                break;
    //        }

    //        Console.WriteLine($"New income is {Income}");
    //    }

    //}


    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}",Name,to);
        }

        public static Person parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Mosh");

            var p = Person.parse("John");
            p.Introduce("Mosh");
        }
    }
}
