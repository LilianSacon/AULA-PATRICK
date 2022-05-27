using System;

namespace Beecrowd_SortSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int valor1, valor2, valor3, j;

            frase = Console.ReadLine();
            var vetorLinha = frase.Split(' ');

            valor1 = int.Parse(vetorLinha[0]);
            valor2 = int.Parse(vetorLinha[1]);
            valor3 = int.Parse(vetorLinha[2]);

            for (j = 0; j < 3; j++)
            {
                if ((valor1 < valor2) && (valor1 < valor3))
                {
                    Console.WriteLine(valor1);
                    valor1 = 999999999;
                }

                if ((valor2 < valor1) && (valor2 < valor3))
                {
                    Console.WriteLine(valor2);
                    valor2 = 999999999;
                }

                if ((valor3 < valor1) && (valor3 < valor2))
                {
                    Console.WriteLine(valor3);
                    valor3 = 999999999;
                }
            }

            Console.WriteLine();

            Console.WriteLine(vetorLinha[0]);
            Console.WriteLine(vetorLinha[1]);
            Console.WriteLine(vetorLinha[2]);
        }

    }
}