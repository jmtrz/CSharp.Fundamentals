using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstExample
            //var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //var numbers = new GenericList<int>();
            //numbers.Add(3);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());
            #endregion

            //System.Nullable - is found in the Dotnet
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetvalueOrdefault());
        }
    }
}
