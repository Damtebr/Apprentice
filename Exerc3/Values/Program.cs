using System;
using static System.Math;
using System.Globalization;
namespace TV
{
    class Pg7
    {
        static void Main(string [] args)
        {
         double pi = 3.14159;
         string [] values = Console.ReadLine().Split(" ");   
         double a = double.Parse(values[0],  CultureInfo.InvariantCulture);
         double b = double.Parse(values[1],  CultureInfo.InvariantCulture);
         double c = double.Parse(values[2], CultureInfo.InvariantCulture);

         double triangle = a * c / 2.0;
         double circle = pi * Pow(c, 2);
         double trapeze =  (a + b) / 2.0 * c;
         double square = b * b;
         double rectangle = a * b;

         System.Console.WriteLine(triangle.ToString("F3", CultureInfo.InvariantCulture));
         System.Console.WriteLine(circle.ToString("F3", CultureInfo.InvariantCulture));
         System.Console.WriteLine(trapeze.ToString("F3", CultureInfo.InvariantCulture));
         System.Console.WriteLine(square.ToString("F3", CultureInfo.InvariantCulture));
         System.Console.WriteLine(rectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}