using System;

namespace FieldsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //All the data we have in orders field will be lost
            // we should use the readonly modifier
            //customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
