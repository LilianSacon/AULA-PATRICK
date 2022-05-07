using System;

namespace Beecrowd_NumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            int numero2 = 0;
            int i;

            for (i = 0; i < 6; i++)
            {
                double.TryParse(Console.ReadLine(), out numero1);
                if (numero1 > 0)
                {
                    numero2++;
                }
            }

             Console.WriteLine(numero2 + " valores positivos"); }
            
        }
    }

           
                