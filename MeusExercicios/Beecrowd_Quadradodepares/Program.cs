using System;

namespace Beecrowd_Quadradodepares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int contador;
            double numero;

            int.TryParse(Console.ReadLine(), out N);

            for (contador = 1; contador <= N; contador ++)
                
            {
                if (contador % 2 == 0)
                {
                    numero = Math.Pow(contador, 2);
                    Console.WriteLine(contador + "^2 = " +numero);
                }
            }
        }
    }
}
