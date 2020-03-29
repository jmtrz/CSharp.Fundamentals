using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(3);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
