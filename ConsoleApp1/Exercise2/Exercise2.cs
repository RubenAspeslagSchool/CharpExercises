using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise2
{
    internal class Exercise2
    {
        internal static void Run()
        {
            Console.WriteLine("---------------------------- Exercise 2 ----------------------------");
            Temperature temperature = new Temperature() { Celsius = 21 }; // 21°C
            Console.WriteLine(temperature.Celsius); // writes temp in °C
            Console.WriteLine(temperature.Fahrenheit); // writes temp in °F
            Console.WriteLine(temperature.Kelvin); // writes temp in K
            //temperature.Celsius = 23; // not possible because Celsius can only be set at object creation
            //temperature.Fahrenheit = 75; // doesn't compile
            (double c, double f, _) = temperature;
            Console.WriteLine($"{c} °C is {f}°F");
        } 
    }
}
