using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{

			// Soma();
			Subtracao();

		}


		static void Soma()
		{
			Console.Clear();
			Console.WriteLine("Primeito Valor: ");
			float v1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Segundo Valor: ");
			float v2 = float.Parse(Console.ReadLine());
			float total = v1 + v2;
			Console.WriteLine("");
			Console.WriteLine($"A soma dos valores é {v1 + v2}");
			Console.ReadKey();
		}

		static void Subtracao()
		{
			Console.Clear();
			Console.WriteLine("Primeito Valor: ");
			float v1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Segundo Valor: ");
			float v2 = float.Parse(Console.ReadLine());
			float total = v1 - v2;
			Console.WriteLine("");
			Console.WriteLine($"O Resultado da subtração é {v1 - v2}");
			Console.ReadKey();
		}
	}
}


