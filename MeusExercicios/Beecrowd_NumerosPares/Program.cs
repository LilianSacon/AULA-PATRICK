using System;

namespace Beecrowd_NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            int contador;

            for (contador = 2; contador <= 100; contador += 2)
                Console.WriteLine(contador);
            {
                if (contador % 2 == 0)
                {
                    numero1 = contador * 2;
                }
                else
                {
                    numero2 = contador + 9;
                }
            }
        }
    }
}
