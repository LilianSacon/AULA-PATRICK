using System;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Primo = true;
            int Numero;

            { Console.WriteLine("Informe um numero:");
                int.TryParse(Console.ReadLine(), out Numero);
            if (Numero < 0)
                { Console.WriteLine("Número Inválido"); }

            else
                {
                    for (int i = 2; i <= (Numero / 2); i++)
                    {
                        if (Numero % i == 0) { Primo = false; break; }
                    }
                    if (Primo)
                    { Console.WriteLine("O número informado é primo"); }
                    else
                    {
                        Console.WriteLine("O número informado não é primo");
                    }
                }
            }
        }
    }
}
