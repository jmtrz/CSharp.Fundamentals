using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }
        public void Work()
        {
            int a = 10;
            int b = 10;

            //delegate that will hold a 
            //method that takes 2 integer 
            //parameters and returns an integer
            Func<int, int, int> multiplyDelegate;
            multiplyDelegate = Multiply;
            int product = multiplyDelegate(a,b);
            Console.WriteLine($"Product = {product }");

            //Takes a parameter of x and y and return 
            //a product of those
            Func<int, int, int> multiplyDelegate2 = 
                (x, y) => (x * y);
            int product2 = multiplyDelegate(a, b);
            Console.WriteLine($"product2 = {product2}");
        }

        public int Multiply(int x,int y)
        {
            return x * y;
        }
    }
}
