using System;
using System.Globalization;

namespace Exerc1
{
    class PgEx1
    {
        static void Main(string [] args)
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";
            byte age = 30;
            int code = 5231;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double avg = 53.234567;

            System.Console.WriteLine("Produtos:");
            System.Console.WriteLine(product1+", cujo preço é "+price1.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(product2+" cujo preço é"+price2.ToString("F2", CultureInfo.InvariantCulture));
            
            System.Console.WriteLine();

            System.Console.Write("Registro:");
            System.Console.WriteLine($"{age} de idade, codigo {code} e genero {gender}");

            System.Console.WriteLine();

            System.Console.WriteLine("Medida com oito casas decimais:"+avg.ToString("F8"));
            System.Console.WriteLine("Arredondado(Três casas decimais):"+avg.ToString("F3"));
            System.Console.WriteLine("Separador decimal invariant culture:"+avg.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}