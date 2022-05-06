using System;

namespace Beecrowd_NotasEMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine("NOTAS: ");
            
            int nota100 = (int)Math.Truncate(valor / 100.0);
            valor = valor - (nota100 * 100);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");

            int nota50 = (int)Math.Truncate(valor / 50.0);
            valor = valor - (nota50 * 50);
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");

            int nota20 = (int)Math.Truncate(valor / 20.0);
            valor = valor - (nota20 * 20);
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");

            int nota10 = (int)Math.Truncate(valor / 10.0);
            valor = valor - (nota10 * 10);
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");

            int nota5 = (int)Math.Truncate(valor / 5.0);
            valor = valor - (nota5 * 5);
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");

            int nota2 = (int)Math.Truncate(valor / 2.0);
            valor = valor - (nota2 * 2);
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");

            Console.WriteLine("MOEDAS: ");

            double moeda1 = Math.Truncate(valor / 1.0);
            valor = valor - (moeda1 * 1);
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");

            double moeda2 = Math.Truncate(valor / 0.5);
            valor = valor - (moeda2 * 0.5);
            Console.WriteLine(moeda2 + " moeda(s) de R$ 0.50");

            double moeda3 = Math.Truncate(valor / 0.25);
            valor = valor - (moeda3 * 0.25);
            Console.WriteLine(moeda3 + " moeda(s) de R$ 0.25");

            double moeda4 = Math.Truncate(valor / 0.1);
            valor = valor - (moeda4 * 0.1);
            Console.WriteLine(moeda4 + " moeda(s) de R$ 0.10");

            double moeda5 = Math.Truncate(valor / 0.05);
            valor = valor - (moeda5 * 0.05);
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");

            double moeda6 = Math.Truncate(valor / 0.01);
            valor = valor - (moeda6 * 0.01);
            Console.WriteLine(moeda6 + " moeda(s) de R$ 0.01");
        }
    }
}
