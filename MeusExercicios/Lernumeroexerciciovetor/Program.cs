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
            int Entrada;
            int Entrada1;
            int i;
            

            int.TryParse(Console.ReadLine(), out Entrada);
                        
            for (i = 0; i < Entrada; i++)
            {
                int.TryParse(Console.ReadLine(), out Entrada1);
                X[i] = Entrada1;               
            }
            for (i = Entrada - 1; i >= 0; i--)
            {
                Console.WriteLine(X[i]);
            }

        }
    }
}
