using System;

namespace Lernumeroexerciciovetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um numero X
            //e na sequencia leia x valores 
            //depois imprima de traz para a frente os valores lidos

            int[] X = new int[5]; ;
            Entrada = new int[5];
            Entrada1 = new int[5];
            int i;
            

            int.TryParse(Console.ReadLine(), out Entrada);
            X = new int[Entrada];
            X[0] = 5;
            for (i = 0; i <= Entrada; i++)
            {
                int.TryParse(Console.ReadLine(), out Entrada1);
                X[i] = Entrada1;
                Console.WriteLine(Entrada);
            }


        }
    }
}
