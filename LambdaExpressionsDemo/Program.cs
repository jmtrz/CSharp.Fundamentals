using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();

            //Another Example
            /* () = > if we dont need param
                 x => if we need 1 param
               (x, y, z) => ..
            */
            Func<int, int> square = number => number * number;

            //Another Example
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);
            Console.WriteLine(result);

            //Another example
            var books = new BookRepository().GetBooks();
            //Replace the IsCheaperThan10Dollars of Lambda
            var cheapBooks = books.FindAll(book => book.Price < 10);
            
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
