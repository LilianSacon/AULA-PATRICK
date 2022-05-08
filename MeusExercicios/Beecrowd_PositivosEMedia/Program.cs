using System;

namespace Beecrowd_PositivosEMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Entrada = 0;
            int Quantidade = 0;
            double Media = 0;
            int i;
            double totalentradas = 0;

            for (i = 0; i < 6; i++)
            {
                double.TryParse(Console.ReadLine(), out Entrada);
                if (Entrada > 0)
                {
                    Quantidade++;
                    totalentradas = totalentradas + Entrada;
                }
            }
            Console.WriteLine(Quantidade + " valores positivos");

            Media = totalentradas / Quantidade;
            Console.WriteLine(Media.ToString("F1"));
        
        
        }

    }
}
