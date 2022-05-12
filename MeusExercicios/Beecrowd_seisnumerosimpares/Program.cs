using System;

namespace Beecrowd_seisnumerosimpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            int contador = 1;

            {
                int.TryParse(Console.ReadLine(), out X);

                while (contador <= 6)
                {
                    if (X % 2 != 0)
                    {
                        contador++;
                        Console.WriteLine(X);
                        
                    }

                    X++;

                }
            }
        }
    }
}
