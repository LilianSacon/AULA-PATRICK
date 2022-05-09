using System;

namespace Beecrowd_Pares_Impares_Positivos_Negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double Entrada = 0;
                int Positivos = 0;
                int Negativos = 0;
                int Pares = 0;
                int Impares = 0;
                int i;

            for (i = 0; i < 5; i++)
            {
                double.TryParse(Console.ReadLine(), out Entrada);
                if (Entrada > 0)
                {
                    Positivos++;

                }
                else if (Entrada < 0)
                {
                    Negativos++;

                }
                if (Entrada % 2 == 0)
                {
                    Pares++;
                }
                else 
                {
                    Impares++;
                }
            }
            Console.WriteLine(Pares + " valor(es) par(es)");
            Console.WriteLine(Impares + " valor(es) impar(es)");
            Console.WriteLine(Positivos + " valor(es) positivo(s)");
            Console.WriteLine(Negativos + " valor(es) negativo(s)");
            }
        }
    }
