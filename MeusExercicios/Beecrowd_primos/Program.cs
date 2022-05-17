using System;

namespace Beecrowd_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int X;
            int contador = 0;
            bool primo = true;

            int.TryParse(Console.ReadLine(), out N);

            for (int j = 0; j < N; j++)
            {
                contador = 0;
                int.TryParse(Console.ReadLine(), out X);

                for (int i = 1; i <= X; i++)
                {
                    if (X % i == 0)
                        contador++;
                }
                if (contador == 2)
                {
                    primo = true;
                    Console.WriteLine(X + " eh primo");
                }
                else
                {
                    Console.WriteLine(X + " nao eh primo");
                }
            }
        }
    }
}










