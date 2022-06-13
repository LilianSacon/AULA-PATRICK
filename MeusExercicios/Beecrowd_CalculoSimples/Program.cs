using System;

namespace Beecrowd_CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string peca;
            int valor1;
            int valor2;
            double valor3;

            peca = Console.ReadLine();
            var vetorLinha = peca.Split(' ');

            valor1 = int.Parse(vetorLinha[0]);
            valor2 = int.Parse(vetorLinha[1]);
            valor3 = double.Parse(vetorLinha[2]);

            Console.WriteLine(valor3 * valor2);
        }
    }
}
