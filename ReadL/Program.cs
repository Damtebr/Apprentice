using System;
using System.Globalization;
namespace RL
{
    class Program
    {
        static void Main(string [] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char ch = char.Parse(Console.ReadLine());

            string [] palavras = Console.ReadLine().Split(' ');
            string nome = palavras[0];
            char sexo = char.Parse(palavras[1]);
            int idade = int.Parse(palavras[2]);
            double altura = double.Parse(palavras[3], CultureInfo.InvariantCulture);
            
            System.Console.WriteLine();

            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(ch);
            System.Console.WriteLine($"{nome} {sexo} {idade} {altura}");

        }
    }
}