using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        #region #Work
        //public void Work()
        //{
        //    Person[] people = new Person[7];
        //    //people[4] = new Person { Name = "Frodo" };
        //    //Person person = people[4];
        //    //Console.WriteLine($"person: {person.Name}");

        //    //Person secondPerson = people[5];
        //    //Console.WriteLine($"secondPerson: {secondPerson}");

        //    people[0] = new Person() { Name = "John" };
        //    people[1] = new Person() { Name = "Paul" };
        //    people[2] = new Person() { Name = "George" };
        //    people[3] = new Person() { Name = "Ringo" };
        //    people[4] = new Person() { Name = "Frodo" };
        //    people[5] = new Person() { Name = "Merry" };
        //    people[6] = new Person() { Name = "Pippin" };

        //    for(int i = 0; i < people.Length;i++)
        //    {
        //        Console.WriteLine($"Name = {people[i].Name}");
        //    }

        //    foreach(Person person in people)
        //    {
        //        Console.WriteLine($"Name = {person}");
        //    }
        //}
        #endregion

        public void Work()
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person george = new Person() { Name = "George Washington", Age = 67 };
            string key = "george";
            dict.Add(key, george);

            dict.Add("john", new Person() { Name = "John Adams", Age = 90 });
            dict.Add("thom", new Person() { Name = "Thomas Jefferson", Age = 90 });
            dict.Add("james", new Person() { Name = "James Madison", Age = 90 });

            Person secondPresident = dict["John"];
            Console.WriteLine($"The second President was: {secondPresident.Name}");
        }

    }
}
