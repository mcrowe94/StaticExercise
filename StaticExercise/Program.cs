using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var celsius = TempConverter.FarhenheitToCelsius(68);
            var farhenheit = TempConverter.CelciusToFarhenheite(20);

            Console.WriteLine("After conversion");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"farhenheit {farhenheit}");
        }
    }
}
