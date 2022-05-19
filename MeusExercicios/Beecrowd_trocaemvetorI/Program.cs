using System;

namespace Beecrowd_trocaemvetorI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            int Entrada;
            int troca;
            int fim = 19;
            int i;

            for (i = 0; i < 20; i++)
            {
                int.TryParse(Console.ReadLine(), out Entrada);
                N[i] = Entrada;
            }
            for (i = 0; i < 10; i++)
            {
                troca = N[i];
                N[i] = N[fim];
                N[fim] = troca;
                fim--;
            }
            for (i = 0; i < 20; i++) 
            {
                Console.WriteLine("N[" + i+ "] = " + N[i]);
            }
        }
    }
}
