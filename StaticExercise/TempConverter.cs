using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace StaticExercise
{
    static class TempConverter
    {




    static public double FahrenheitToCelsius(double fTemp)
        {
            Console.WriteLine($"Converting {fTemp} to celsius");
            Console.WriteLine($"{fTemp} = {(fTemp - 32) * (5 / 9)} celsius");
            Console.WriteLine($"Press return to continue> ");
            Console.ReadLine();
            return (fTemp - 32) * (5 / 9);
        }

        static public double CelsiusToFahrenheit(double cTemp)
        {
            Console.WriteLine($"Converting {cTemp} to Fahrenheits");
            Console.WriteLine($"{cTemp} = {(cTemp * 1.8) +32 } Fahrenheit ");
            Console.WriteLine($"Press return to continue> ");
            Console.ReadLine();
            return   (cTemp * 1.8) + 32;
        }


    }
}
