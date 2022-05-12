using System;

namespace Beecrowd_Intervalo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int X;
            int i;
            int contadorin=0;
            int contadorout = 0;

            int.TryParse(Console.ReadLine(), out N);

            for (i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out X);

                if ((X >= 10) && (X <= 20))
                {
                    contadorin++ ;
                }
                else
                {
                    contadorout++;
                }
            }
            Console.WriteLine(contadorin + (" in"));
            Console.WriteLine(contadorout + (" out"));
        }
    }
}
