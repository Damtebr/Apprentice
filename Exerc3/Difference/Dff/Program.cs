using System;

namespace DFF
{
    class Pg3
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int difference = (a * b - c * d);

            System.Console.WriteLine($"DIFERENÇA = {difference}");
        }
    }
}