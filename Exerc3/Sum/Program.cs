using System;

namespace E3
{
    class Pg
    {
        static void Main(string [] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;

            System.Console.WriteLine($"SOMA = {sum}");
        }
    }
}