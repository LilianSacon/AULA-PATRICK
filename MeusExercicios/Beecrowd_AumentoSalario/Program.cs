using System;

namespace Beecrowd_AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double.TryParse(Console.ReadLine(), out salario);

            if (salario >= 0 && salario <= 400)
            {
                Console.WriteLine("Novo salario: {0}", (salario + ((salario * 15) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: {0}", ((salario * 15) / 100).ToString("F2"));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400 && salario <= 800)
            {
                Console.WriteLine("Novo salario: {0}", (salario + ((salario * 12) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: {0}", ((salario * 12) / 100).ToString("F2"));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800 && salario <= 1200)
            {
                Console.WriteLine("Novo salario: {0}", (salario + ((salario * 10) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: {0}", ((salario * 10) / 100).ToString("F2"));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200 && salario <= 2000)
            {
                Console.WriteLine("Novo salario: {0}", (salario + ((salario * 7) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: {0}", ((salario * 7) / 100).ToString("F2"));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000)
            {
                Console.WriteLine("Novo salario: {0}", (salario + ((salario * 4) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: {0}", ((salario * 4) / 100).ToString("F2"));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
