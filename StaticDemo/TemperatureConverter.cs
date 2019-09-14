using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class TemperatureConverter
    {
        public double CelsiousToFahrenheit(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5/9;
            return celsius;
        }

        //if static is used no need to instantiate the class to call the methods

        //public static double CelsiousToFahrenheit(string tempCelsius)
        //{
        //    double celsius = Double.Parse(tempCelsius);
        //    double fahrenheit = (celsius * 9 / 5) + 32;
        //    return fahrenheit;
        //}

        //public static double FahrenheitToCelsius(string tempFahrenheit)
        //{
        //    double fahrenheit = double.Parse(tempFahrenheit);
        //    double celsius = (fahrenheit - 32) * 5 / 9;
        //    return celsius;
        //}

        private void Computer()
        {
            var grades = new List<double>() { 12.7, 10.3,6.11,4.1 };
            grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number,lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The Highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {result}");
        }
    }
}
