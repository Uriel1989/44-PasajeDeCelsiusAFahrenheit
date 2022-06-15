using System;

namespace _44_PasajeDeCelsiusAFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius, Fahrenheit;

            Console.WriteLine("Ingrese un valor, será tomado como grados Celcius y pasado a Fahrenheit:");
            Celcius = Convert.ToInt32(Console.ReadLine());

            Fahrenheit = (Celcius * 1.8) + 32;

            Console.WriteLine(Celcius + " grados Celcius son " + Fahrenheit + " grados Fahrenheit");

            Console.ReadKey();
        }
    }
}
