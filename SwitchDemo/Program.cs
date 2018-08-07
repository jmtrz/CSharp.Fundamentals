using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        enum Movies
        {
            Casablanca,
            GodFather,
            Matrix
        }
        static void Main(string[] args)
        {
            Movies bestMovie = Movies.GodFather;

            switch (bestMovie)
            {
                case Movies.Casablanca:
                    Console.WriteLine("Ahh, Bogie and Bacall");
                    break;
                case Movies.GodFather:
                    Console.WriteLine("I'll make him an offer");
                    break;
                case Movies.Matrix:
                    Console.WriteLine("Will you take the red pill or the blue?");
                    break;
                default:
                    Console.WriteLine("You need a chooise");
                    break;
            }
        }
    }
}
