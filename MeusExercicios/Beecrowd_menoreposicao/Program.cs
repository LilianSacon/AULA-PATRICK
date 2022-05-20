using System;

namespace Beecrowd_menoreposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int valores;
            int menor = 0;
            int posicao= 0;
            string linha;
            
            int.TryParse(Console.ReadLine(), out N);
            //int[] X = new int[N];

            linha = Console.ReadLine();
            var vetorLinha = linha.Split(' ');

            for (int i = 0; i < N; i++)
            {
                int.TryParse( vetorLinha[i], out valores);
                //X[i] = valores;
                if (i == 0)
                {
                    menor = valores;
                    posicao = i;
                }
                if (valores < menor)
                {
                    menor = valores;
                    posicao = i;
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}
