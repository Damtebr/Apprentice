using System;
using System.Globalization;

namespace SdCSharp
{
    class Program
    {
        static void Main(string [] args)
        {
            int age = 29;
            double salary = 32.99121;
            string name = "Gustavo santos";
            char gender = 'M';

            //System.Console.WriteLine($"{name} tem {age} anos do sexo {gender} e tem um salário de {salary:F2}");
            System.Console.WriteLine(name+" tem "+age+ " anos do sexo "+gender+" e tem um salario de "+salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
