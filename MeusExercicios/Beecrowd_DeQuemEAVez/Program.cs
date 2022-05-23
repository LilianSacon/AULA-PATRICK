using System;

namespace Beecrowd_DeQuemEAVez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QT;
            int i;
            double total;
            string linha1;
            string linha2;
            
            int.TryParse(Console.ReadLine(), out QT);

            for (i = 0; i < QT ; i++)
            {
                linha1 = Console.ReadLine();
                var texto = linha1.Split(' ');

                linha2 = Console.ReadLine();
                var valores = linha2.Split(' ');

                total = double.Parse(valores[0]) + double.Parse(valores[1]);

                if (total % 2 == 0)
                {
                    if (texto[1] == "PAR")
                        Console.WriteLine(texto[0]);
                    else
                        Console.WriteLine(texto[2]);

                }
                else
                {
                    if (texto[1] == "IMPAR")
                        Console.WriteLine(texto[0]);
                    else
                        Console.WriteLine(texto[2]);

                }

            }

        }
    }
}
