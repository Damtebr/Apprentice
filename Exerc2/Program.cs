using System;
using System.Globalization;
namespace E2
{
	class Pg
	{
		static void Main(string [] args)
		{
				Console.WriteLine("Entre com seu nome Completo:");
				string nome = Console.ReadLine();
				
				Console.WriteLine("Quantos quartos tem na sua casa:");
				int quartos = int.Parse(Console.ReadLine());
				
				Console.WriteLine("Entre com um preço de um produto:");
				double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				
				Console.WriteLine("Entre com seu ultimo nome, idade e altura):");
				string [] palavras = Console.ReadLine().Split(' ');
				string ultimoNome = palavras[0];
				int idade = int.Parse(palavras[1]);
				double altura = double.Parse(palavras[2], CultureInfo.InvariantCulture);

				System.Console.WriteLine();

				System.Console.WriteLine(nome);
				System.Console.WriteLine(quartos);
				System.Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
				System.Console.WriteLine(ultimoNome+"\n"+idade+"\n"+altura.ToString(CultureInfo.InvariantCulture));

		}
	}
}

