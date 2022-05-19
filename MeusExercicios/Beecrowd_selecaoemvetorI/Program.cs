using System;

namespace Beecrowd_selecaoemvetorI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[100];
            double Entrada;
            int i;

            for (i = 0; i < 100; i++)
            {
                Double.TryParse(Console.ReadLine(), out Entrada);
                A[i] = Entrada;
            }
            for (i = 0; i < 100; i++)
                if (A[i] <= 10)
            {
                    Console.WriteLine("A[" + i + "] = " + A[i].ToString("F1"));
            }
        }
    }
}
