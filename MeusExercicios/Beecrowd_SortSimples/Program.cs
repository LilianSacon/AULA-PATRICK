using System;

namespace Beecrowd_SortSimples
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numeros = new int[3];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("");
				numeros[i] = Convert.ToInt32(Console.ReadLine());
			}

			Array.Sort(numeros);
			Console.Write("\n\n");
			foreach (int p in numeros) Console.WriteLine(p);
		}
	}
}
