using System.Collections.Generic;

namespace FieldsDemo
{
    public class Customer
    {
        public int Id;
        public string Name;
        //public List<Order> Orders = new List<Order>();
        //We can only initialize an readonly in constructor or in variable class level
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //....
            //Orders = new List<Order>();
        }
    }
}
