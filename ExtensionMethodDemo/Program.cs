using System.Collections.Generic;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah";
            var shortenedPost = post.Shorten(5);

            //IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18};
            

            System.Console.WriteLine(shortenedPost);
        }
    }

}
