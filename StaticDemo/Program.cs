using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while(selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)arenheit to Celsius or Q)uit");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                switch(selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the celsius temperature: ");
                        TemperatureConverter converter = new TemperatureConverter();
                        fahrenheit = converter.CelsiousToFahrenheit(Console.ReadLine());
                        //code below will be used once the method to be use is in static
                        //fahrenheit = TemperatureConverter.CelsiousToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit:{fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        converter = new TemperatureConverter();
                        //code below will be used once the method to be use is in static
                        //fahrenheit = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        fahrenheit = converter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius:{celsius:f2}");
                        break;
                    case "q":
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }
    }
}
