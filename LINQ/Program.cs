using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Another example
            //Worker work = new Worker();

            #region LINQExample1
            var books = new BookRepository().GetBooks();

            //LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //Use link instead of the below code
            /*var cheapBooks = new List<Book>();
            //foreach(var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            }*/

            //LINQ Extension Methods
            var cheapBooks = books.Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);


            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book);
            //    Console.WriteLine(book.Title  + " " + book.Price);
            #endregion

            //will generate an error if item not found
            var book = books.Single(b => b.Title == "ASP.NET MVC");
            //Will return Null
            var bookz = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");


            //Gets the first item with the indicated value
            //var bookzz = books.First(b => b.Title == "C# Advanced Topics");
            var bookzz = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            var bookzzz = books.Skip(2).Take(3);

            Console.WriteLine(book.Title);
        }
    }
}
