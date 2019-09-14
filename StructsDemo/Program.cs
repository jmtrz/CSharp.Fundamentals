using System;

namespace StructsAndEnumsDemo
{
    //If you want to save memory
    struct Person
    {
        public string name;
        public string eyeColor;
        public int age;
    }

    /*Auto assignment in list is value is not assigned
     * Because its a constant
     */
    public enum ProductCodes
    {
        Milk = 0,
        Juice = 1,
        Tea = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Structs
            Person person1;
            person1.name = "Mosh";
            Console.WriteLine(person1.name);

            //Enum
            var test = ProductCodes.Milk;
            Console.WriteLine((int)test);

            int test2 = 1;
            Console.WriteLine((ProductCodes)test2);

            int test3 = (int)ProductCodes.Milk;
            Console.WriteLine(test3);

            string test4 = "Tea";
            ProductCodes getParse;
            bool checkParse = Enum.TryParse(test4,out getParse);
            Console.WriteLine(getParse);
            Console.WriteLine(checkParse);
        }
    }

    class Shipping
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public void Ship()
        {
            var method = ShippingMethod.Express;
            var methodId = 3;

            Console.WriteLine((int)method);
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
        
    }
}
