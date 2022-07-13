using System;
using System.Globalization;
namespace Emp
{
    class Pg4
    {
        static void  Main(string [] args)
        {
            int code = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = hours * salary;
           // total.ToString("F2", CultureInfo.InvariantCulture);

            System.Console.WriteLine($"NUMBER  = {code}\nSALARY = $ {total}");

        }
    }
}