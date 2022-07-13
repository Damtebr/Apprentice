using System;
using System.Globalization;
namespace Pt
{
    class Pg6
    {
        static void Main(string [] args)
        {
            string [] parts1 = Console.ReadLine().Split(" ");
            int code1 = int.Parse(parts1[0]);
            int nParts = int.Parse(parts1[1]);
            double value = double.Parse(parts1[2], CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("Pt2:");
            string [] parts2 = Console.ReadLine().Split(" ");
            int code2 = int.Parse(parts2[0]);
            int nPart2 = int.Parse(parts2[1]);
            double value2 = double.Parse(parts2[2], CultureInfo.InvariantCulture);

            double calc1 = value * nParts;
            double calc2 = nPart2 * value2;

            double total  = calc1 + calc2;
            System.Console.WriteLine($"VALOR A PAGAR = ${total:F2}");
        }
    }
}