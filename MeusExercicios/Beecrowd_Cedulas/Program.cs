using System;

namespace Beecrowd_Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine(valor);
            
            int nota100 = (int) Math.Truncate(valor / 100.0);
            valor = valor - (nota100 * 100);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            
            int nota50 = (int)Math.Truncate(valor  / 50.0);
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

            int nota1 = (int)Math.Truncate(valor / 1.0);
            valor = valor - (nota1 * 1);
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");




        }
    }
}
