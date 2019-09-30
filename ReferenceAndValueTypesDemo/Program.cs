using System;

namespace ReferenceAndValueTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            var b = a;

            b++;
            //Whats gonna be the value of a and b
            /*When you copy the value type into a variable the copy of 
             * that value is taken and stored in the target variable
            */
            Console.WriteLine(string.Format("a:{0} b:{1}",a,b));


            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0;

            /*In this scenario what do yout think is going to be the first
             element of array1?*/

            Console.WriteLine(string.Format("a:{0} b:{1}", array1[0], array2[0]));
        }
    }

    public class Person
    {
        public int Age;
    }

    class ProgramReference
    {
        static void Start()
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
