using System;

namespace Beecrowd_Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            const double notaA = 3.5;
            const double notaB = 7.5;
            double resultado;
            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);

            resultado = ((notaA * 100) / (notaA + notaB) * A) / 100 +
                ((notaB * 100) / (notaA + notaB) * B) / 100;
            Console.WriteLine("MEDIA = " + resultado.ToString("F5"));
        }
    }
}
