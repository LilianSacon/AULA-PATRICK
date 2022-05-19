using System;

namespace Beecrowd_preenchimentodevetorI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] N = new int[10];
            int Entrada;
            int i;

            int.TryParse(Console.ReadLine(), out Entrada);
            N[0] = Entrada;
            
            for (i = 1; i < 10; i++)
            { 
                N[i] = N[i - 1] * 2; 
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }
        }
    }
}
