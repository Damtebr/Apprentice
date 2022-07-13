using System;
using static System.Math;
using System.Globalization;

namespace C
{
    class Pg2
    {
        static void Main(string [] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double area = pi* Pow(raio, 2);

            System.Console.WriteLine("A = "+area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}