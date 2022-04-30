using System;

namespace Beecrowd_Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            const double notaA = 2;
            const double notaB = 3;
            const double notaC = 5;
            double resultado;
            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);
            double.TryParse(Console.ReadLine(), out C);

            resultado = ((notaA * 100) / (notaA + notaB + notaC) * A) / 100 +
                        ((notaB * 100) / (notaA + notaB + notaC) * B) / 100 +
                        ((notaC * 100) / (notaA + notaB + notaC) * C) / 100;
            Console.WriteLine("MEDIA = " + resultado.ToString("F1"));
        }
    }
}
